using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProtectionDepartment
{
    public abstract class Citizen
    {
        readonly int passport;
       string name;
        string surname;
        //int age;
        public int Passport { get {return passport; } }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Citizen()
        { 
            this.passport = this.GetHashCode();
            
        }
    }
}
