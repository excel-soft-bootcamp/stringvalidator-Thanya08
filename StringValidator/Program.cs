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
            NullChecking checking = new NullChecking();
            StringValidator validate = new StringValidator(checking);
            validate.IsValidString(data);

            LengthChecking length = new LengthChecking();
            StringValidator _length = new StringValidator(length);
            _length.IsValidString(data);

            StringStartsWith starts = new StringStartsWith();
            StringValidator _starts = new StringValidator(starts);
            _starts.IsValidString(data);
        }
    }
}
