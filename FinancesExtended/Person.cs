using System;
using System.Collections.Generic;
using System.Text;

namespace FinancesExtended
{
    internal class Person
    {
        private string name;
        private int age;
        private string email;
        private Wallet vacation;
        private Wallet school;

        public Person (string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Person (string name) 
        { 
            this.name=name;
            this.age = 999;
            this.email = "unknown";
        }

        public Person(string name, int age, string email,
                       string aDiscription1, int aBalance1,
                       string aDiscription2, int aBalance2)
        {
            this.name = name;
            this.age = age;
            this.email = email;
 
            this.vacation = new Wallet(aDiscription1, aBalance1);
            
            this.school = new Wallet(aDiscription2, aBalance2); 
            
        }

       public Wallet GetVacation()
        {
            return vacation;
        }

        public Wallet GetSchool()
        {
            return school;
        }

        public string GetInfo()
        {
            return $"Wallet belongs to {name} ( age: {age}, email: {email})";
        }

        public string GetVacationAmountInfo()
        {
            return $"{vacation.GetDescription()} has Euro {vacation.GetBalance()} ";
        }

        public string GetSchoolAmountInfo()
        {
            return $"{school.GetDescription()} has Euro {school.GetBalance()} ";
        }






    }
}
