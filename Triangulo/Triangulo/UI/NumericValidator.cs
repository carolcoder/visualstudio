using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.UI
{
    class NumericValidator : DecoratorValidator
    {

        public override Message isValid(string value)
        {
            Message msg = base.isValid(value);
            if (msg.IsValid)
            {
                try
                {
                    int num = Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    msg.IsValid = false;
                    msg.Description = "Não é valor numérico.";
                }                
            }
            return msg;
        }
     }
}
