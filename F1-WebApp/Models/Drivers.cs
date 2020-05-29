using System;

namespace F1_WebApp.Models
{
    public class Drivers
    {
        private DriversDataContext context;

        public String DriverID { get; set; }

        public int PermanentNumber { get; set; }

        public string Code { get; set; }

        public string Url { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string DateOfBirth { get; set; }

        public string Nationality { get; set; }
    }
}
