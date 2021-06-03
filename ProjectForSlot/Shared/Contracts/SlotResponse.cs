using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSlot.Shared.Contracts
{
    public class SlotResponse
    {
        public List<slot> slot;
    }
    public class slot
    {
        public string name { get; set; }
        public string address { get; set; }
        public string state_name { get; set; }
        public string district_name { get; set; }
        public int pincode { get; set; }
        public int available_capacity_dose1 { get; set; }
        public int available_capacity_dose2 { get; set; }
        public string fee { get; set; }
        public int min_age_limit { get; set; }
        public string vaccine { get; set; }
    }
}
