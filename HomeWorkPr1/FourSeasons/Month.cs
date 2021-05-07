using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSeasons
{
    class Month
    {
        readonly string name;
        readonly int days;
        readonly int iD;
        
        public string Name 
        { get { return name; } }
       
        public int Days
        { get {return days; } }
        public int ID
        { get { return iD; } }
        public Month(int iD, string name, int days)
        {
            this.iD = iD;
            this.name = name;
            this.days = days;
        }
    }
}
