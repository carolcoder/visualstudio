using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.UI
{
    class Message
    {
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                this.description = value;
            }
        }

        private bool isValid;
        public bool IsValid {
            get{ return isValid;}
            set{
                this.isValid = value;
            }
        }
   
    }
}
