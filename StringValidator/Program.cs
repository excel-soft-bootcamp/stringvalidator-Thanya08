using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = "excel";
           
            StringValidator validate = new StringValidator(new NullChecking());
            validate.IsValidString(data);

           
            StringValidator _length = new StringValidator(new LengthChecking());
            _length.IsValidString(data);

           
            StringValidator _starts = new StringValidator(new StringStartsWith());
            _starts.IsValidString(data);
        }
    }
}
