using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders8ci
{
    public class human

    {
        public string Surname;
        public string Gander;

        // public human(string Surname, string SGander)
        // {
        //     this.Surname = Surname;
        //     this.Gander = Gander;
        // }
        public string Fullinfo()
        {
            return $"{Surname} {Gander}";
        }
        

    }
}