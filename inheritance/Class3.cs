using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Class3 : Class2
    {
        public string teacher;

        public void setvalues(string teach,string[] subject, int[] scode,string[] nam, string[]cl, int[] rol)
        {
            this.teacher = teach;
            this.set(subject, scode);
            this.set(nam, cl, rol);
        }

    }
}
