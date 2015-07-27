using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.Model
{
    class EscalenoHandler : TrianguloHandler
    {

        public override string GetTrianguloType(int side1, int side2, int side3)
        {
            string result = "";

            if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                result = "Escaleno";
            }
            return result;
        }
        
    }
}
