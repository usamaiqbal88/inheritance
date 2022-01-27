using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class  Class2 : Class1
    {
        public string[] subjectname = new string[3];
        public int[] subjectcode = new int[3];
        
        public void set(string [] subject, int[] scode)
        {
            this.subjectname = subject;
            this.subjectcode = scode;
        }
        
    }
}
