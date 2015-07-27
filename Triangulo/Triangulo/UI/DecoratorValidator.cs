using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.UI
{
    // Decorator pattern
    class DecoratorValidator : Validator
    {

        public void SetValidator(Validator validator)
        {
            this.validator = validator;
        }

        public override Message isValid(string value)
        {
            Message msg = new Message();
            msg.IsValid = true;
            msg.Description="OK";
            if (this.validator != null)
            {
                msg = this.validator.isValid(value);
            }
            return msg;
        }
    }
}
