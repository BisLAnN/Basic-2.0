using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }


        public User()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            Age = int.MinValue;
            Salary = decimal.MinValue;
        }

        public User(string firstName, string middleName, string lastName, int age,
            decimal salary)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }


        public override string ToString() => $"ФИО: {FirstName} {MiddleName} {LastName}\n" +
            $"Дата рождения: {Age}\n" + $"Зарплата:{Salary}";
    }
}
