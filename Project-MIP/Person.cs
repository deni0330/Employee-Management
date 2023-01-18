using System;
using System.Collections.Generic;
using System.Text;

namespace Project_MIP
{
     class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }

        public string Education { get; set; }

        public string FullName()
        {
            return "Employee Name: " + FirstName + " " + LastName;
        }

    }

    class Employee:Person
    {
        
        public int EmpID { get; set; }
        public string Position { get; set; }


        public string EmployementDate { get; set; }


    }

  
}
