using System;

namespace dotnetCore_WebAPI_ActuallyBrandNew.Models
{
    public class Member : Person
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }        
    }
}