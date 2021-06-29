using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
    class StringStartsWith:Ivalidate
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}
