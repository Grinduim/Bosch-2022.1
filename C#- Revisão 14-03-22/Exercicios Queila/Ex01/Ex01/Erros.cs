using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class Erros:Exception
    {
        public Erros(string msg):base(msg)
        {

        }
        
    }

}
