using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.Model
{
    // Chain of responsability pattern
    abstract class TrianguloHandler
    {
        protected TrianguloHandler next;

        public void SetNext(TrianguloHandler next)
        {
            this.next = next;
        }

        public abstract string GetTrianguloType(int side1, int side2, int side3);
    }
}
