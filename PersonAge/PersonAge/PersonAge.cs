using System;
using System.Collections.Generic;
using System.Text;

namespace PersonAge
{
    public class PersonAge
    {
        public DateTime DateOfBirth { get; set; }

        public int Age(DateTime date)
        {
            var timeSpan = DateTime.Today - DateOfBirth;
            var years = timeSpan.Days / 365;
            
            return years;
        }
    }
}
