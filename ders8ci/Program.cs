using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders8ci
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           human a = new human();
           a.Surname = "Eyvazov";
           a.Gander = "man";
           string aFullname = a.Fullinfo();

           Console.WriteLine(aFullname);
           doctor b = new doctor();
           b.No = 32;
           b.Speciality = "hekim";
           b.Experience = 15;
           string bfullinfo = b.Fullinfo();
           Console.WriteLine(bfullinfo);

        }
        
    }

    
}
//1.
// Asagidaki sturukturda classlar qurun
// Human class
// - Name
//     - Surname
//     - Gender
// Doctor: Human 
//     - No
//     - Speciality
//     - Experience
//     
// Her iki classda ShowInfo metodunuz olsun (console penceresine hemin obyektin
// melumatlarini yazdiran metod) ve bu metod miras alan classda override olunsun.

// Consoledan istifadeci istediyi sayda Doctor yaratsin, ve en sonda hemin
// doctorlarin infolari console penceresinde gosterilsin
