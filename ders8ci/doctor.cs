using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ders8ci
{
    public class doctor: human

    {
    public int No;
    public string Speciality;
    public int Experience;
    public string Fullinfo()
    {
        return $"{No} {Speciality} {Experience}";
    }
    }
}