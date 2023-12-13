using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject
{
    public interface IInput
    {
        
         public string explorePlateau { get; set; }
        public string plateauCoordinates { get; set; }
        public string upperRightCoordinates { get; set; }
        public void takeUpperRightCoordinates();
        public void takeexplorePlateauInstructions();
        public string[] Seperateinput();

    }
}
