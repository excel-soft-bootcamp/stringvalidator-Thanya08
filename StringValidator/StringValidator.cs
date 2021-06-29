using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidatorProgram
{
    public class StringValidator
    {
        Ivalidate validate;
        public StringValidator(Ivalidate validate)
        {
            this.validate = validate;
        }
        public bool IsValidString(string data)
        {
          return validate.IsValidString(data);
        }
    }
}
