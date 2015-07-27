using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.UI
{
    abstract class Validator
    {
        protected Validator validator;

        public abstract Message isValid(String value);
    }
}
