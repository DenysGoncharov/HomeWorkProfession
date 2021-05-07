using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProtectionDepartment
{
    class Worker : Citizen
    {
        public Worker(string name, string surname):base()
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
