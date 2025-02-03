using System;

namespace PartnersApp
{
    public class Partner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CEO { get; set; }
        public string PhoneNumber { get; set; }
        public int Rating { get; set; }
        public int Discount { get; set; }
        public string Category { get; set; }
        public int NumOfSoldProducts { get; set; }
    }
}
