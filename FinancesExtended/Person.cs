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

        public Person (string name) { 
        
        }

        public Person(string name, int age, string email,
                       string aDiscription1, int aBalance1,
                       string aDiscription2, int aBalance2)
        {

        }

        

    }
}
