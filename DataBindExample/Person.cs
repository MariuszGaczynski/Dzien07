using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindExample
{
    class Person
    {
        private string fName;
        private string lName;
        private int age;
        private string job;
        private bool active;
        public Person(string fName, string lName, int age, string job, bool active)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.job = job;
            this.active = active;
        }

        public string FName { get { return fName; } }
        public string LName { get { return lName; } }
        public int Age { get { return age; } }
        public string Job { get { return job; } }

        public bool Active { get { return active; } }
        public string FullName {get { return fName + " " + lName; } }
        
    }
}
