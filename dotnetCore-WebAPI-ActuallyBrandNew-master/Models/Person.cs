using System;

namespace dotnetCore_WebAPI_ActuallyBrandNew.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }

    }
}