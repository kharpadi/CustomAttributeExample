using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeExample
{
    public class Student
    {
        [RequiredArea]
        public string Name { get; set; }
        [RequiredArea]
        public string Surname { get; set; }
        [RequiredArea]
        public string Department { get; set; }
        [RequiredArea]
        [DateFormat]
        public string DateOfBirth { get; set; }
    }
}
