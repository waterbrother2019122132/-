using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Manage
    {
        Person[] people;
        VIPPerson[] vippeople;

        public Manage()
        {
            people = new Person[501];
            vippeople = new VIPPerson[501];
        }

        public Person[] People
        {
            get { return people; }
            set { }
        }

        public VIPPerson[] VIPPeople
        {
            get { return vippeople; }
            set { }
        }
    }
}
