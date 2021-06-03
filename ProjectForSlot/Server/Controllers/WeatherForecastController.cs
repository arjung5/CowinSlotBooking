using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectForSlot.Shared;
using ProjectForSlot.Shared.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForSlot.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet("GetOtp/{Con}")]
        public async Task<OtpResponse> GetOtp(string con)
        {
            OtpRequest otpRequest = new OtpRequest();
            otpRequest.mobile = con;

            OtpResponse otpResponse = new OtpResponse();
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var json = JsonConvert.SerializeObject(otpRequest);
                using (var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json"))
                {
                    var response = await http.PostAsync("https://cdn-api.co-vin.in/api/v2/auth/public/generateOTP", stringContent);
                    if (response.IsSuccessStatusCode)
                    {
                        var strResponse = await response.Content.ReadAsStringAsync();
                        try
                        {
                            otpResponse = JsonConvert.DeserializeObject<OtpResponse>(strResponse);
                        }
                        catch (Exception ex)
                        {

                        }


                    }
                }
            }
            return otpResponse;
        }

        [HttpGet("VerifyOtp/{Con}/{txn}")]
        public async Task<ValidateOtpResponse> VerifyOtp(string con, string txn)
        {
            con = await sha256(con);
            ValidateOtpRequest validateOtpRequest = new ValidateOtpRequest();
            validateOtpRequest.otp = con;
            validateOtpRequest.txnId = txn;

            ValidateOtpResponse validateOtpResponse = new ValidateOtpResponse();

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var json = JsonConvert.SerializeObject(validateOtpRequest);
                using (var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json"))
                {
                    var response = await client.PostAsync("https://cdn-api.co-vin.in/api/v2/auth/public/confirmOTP", stringContent);
                    if (response.IsSuccessStatusCode)
                    {
                        var strContent = await response.Content.ReadAsStringAsync();
                        validateOtpResponse = JsonConvert.DeserializeObject<ValidateOtpResponse>(strContent);
                    }
                }
            }
            return validateOtpResponse;

        }

        public async Task<string> sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        List<string> pincodes = new List<string>();

        ///v2/appointment/sessions/public/findByPin?pincode=110001&date=31-03-2021&vaccine=COVISHIELD
        [HttpGet("FindCenters/{con}/{dose}/{vacc}/{ageGrp}/{date}")]
        public async Task<Dictionary<string, List<slot>>> FindCenters(string con, string dose, string vacc, string ageGrp,string date)
        {
            var dateInp = date.Replace('@','/');
            if (dose.ToLower() == "first")
            {
                dose = "available_capacity_dose1";
            }
            else if (dose.ToLower() == "second")
            {
                dose = "available_capacity_dose2";
            }
            for (int i = 110001; i <= 110096; i++)
            {
                pincodes.Add(i.ToString());
            }
            var age = 0;
            if (ageGrp.ToLower() == "above")
            {
                age = 45;
            }
            if(dateInp=="nothing")
            {
                DateTime dateTime = DateTime.UtcNow.Date;
                dateInp = dateTime.ToString("dd/MM/yyyy"); 
            }
            if(vacc.Contains("x")||vacc.Contains("X"))
            {
                vacc = "COVAXIN";
            }
            else
            {
                vacc = "COVISHIELD";
            }
            SlotResponse slotResponse = new SlotResponse();

            slotResponse.slot = new List<slot>();

            List<Session> responseFromSlots = new List<Session>();
            foreach (var pincode in pincodes)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                   
                   
                    var response = await client.GetAsync("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByPin?pincode=" + pincode + "&date=" + dateInp + "&vaccine=" + vacc);
                    if (response.IsSuccessStatusCode)
                    {
                        var strContent = await response.Content.ReadAsStringAsync();
                        var responseFromSlot = JsonConvert.DeserializeObject<Root>(strContent);
                        foreach (var value in responseFromSlot.sessions)
                        {
                            slot slot = new slot();
                            if (age >= 45)
                            {
                                if (dose == "available_capacity_dose1")
                                {
                                    if (value.available_capacity_dose1 > 0 && vacc == value.vaccine && value.min_age_limit == 45)
                                    {
                                        slot.address = value.address;
                                        slot.available_capacity_dose1 = value.available_capacity_dose1;
                                        slot.district_name = value.district_name;
                                        slot.fee = value.fee;
                                        slot.pincode = value.pincode;
                                        slot.name = value.name;
                                        slot.vaccine = value.vaccine;
                                        slot.min_age_limit = value.min_age_limit;
                                        slot.state_name = value.state_name;
                                        slotResponse.slot.Add(slot);
                                    }
                                }
                                else if (value.available_capacity_dose2 > 0 && vacc == value.vaccine && value.min_age_limit == 45)
                                {
                                    slot.address = value.address;
                                    slot.available_capacity_dose1 = value.available_capacity_dose2;
                                    slot.district_name = value.district_name;
                                    slot.fee = value.fee;
                                    slot.pincode = value.pincode;
                                    slot.name = value.name;
                                    slot.vaccine = value.vaccine;
                                    slot.min_age_limit = value.min_age_limit;
                                    slot.state_name = value.state_name;
                                    slotResponse.slot.Add(slot);
                                }
                            }
                            else
                            {
                                if (dose == "available_capacity_dose1")
                                {
                                    if (value.available_capacity_dose1 > 0 && vacc == value.vaccine && value.min_age_limit == 18)
                                    {
                                        slot.address = value.address;
                                        slot.available_capacity_dose1 = value.available_capacity_dose1;
                                        slot.district_name = value.district_name;
                                        slot.fee = value.fee;
                                        slot.pincode = value.pincode;
                                        slot.name = value.name;
                                        slot.vaccine = value.vaccine;
                                        slot.min_age_limit = value.min_age_limit;
                                        slot.state_name = value.state_name;
                                        slotResponse.slot.Add(slot);
                                    }
                                }
                                else if (value.available_capacity_dose2 > 0 && vacc == value.vaccine && value.min_age_limit == 18)
                                {
                                    slot.address = value.address;
                                    slot.available_capacity_dose1 = value.available_capacity_dose2;
                                    slot.district_name = value.district_name;
                                    slot.fee = value.fee;
                                    slot.pincode = value.pincode;
                                    slot.name = value.name;
                                    slot.min_age_limit = value.min_age_limit;
                                    slot.state_name = value.state_name;
                                    slot.vaccine = value.vaccine;
                                    slotResponse.slot.Add(slot);
                                }
                            }
                        }
                    }

                }
            }
            Dictionary<string, List<slot>> keyValuePairs = new Dictionary<string, List<slot>>();
            keyValuePairs.Add("value", slotResponse.slot);
            return keyValuePairs;

        }
    }
}
