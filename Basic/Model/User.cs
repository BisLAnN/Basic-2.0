using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Model
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }


        public User()
        {
            ID = int.MinValue;
            FullName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Salary = decimal.MinValue;
        }

        public User(int id, string fullName, DateTime dateOfBirth,
            decimal salary)
        {
            ID = id;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }


        public override string ToString() => $"ID:{ID}\n"+$"ФИО: {FullName}\n" +
            $"Дата рождения: {DateOfBirth}\n" + $"Зарплата:{Salary}";
    }
}
