﻿namespace Dublin.Domain.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Bssid { get; set; }
        public bool Active { get; set; }

        public Person()
        {
                
        }
    }
}
