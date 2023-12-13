using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject
{
    public class Takeinput : IInput
    {

       public string explorePlateau { get; set; }
         public string upperRightCoordinates { get; set; }
        public string plateauCoordinates { get; set; }
        public string[] inputArr=null;


        public void takeexplorePlateauInstructions()
        {
            Console.WriteLine("Enter explorePlateau instructions ");
            explorePlateau = Console.ReadLine();
        }

       public void takeUpperRightCoordinates()
        {
            Console.WriteLine("Enter UpperRightCoordinates ");
            upperRightCoordinates= Console.ReadLine();



        }
        public void takeplateaucoordinates()
        {
            Console.WriteLine("Enter Plateau Coordinates ");
            plateauCoordinates = Console.ReadLine();

        }
        public string[] Seperateinput()
        { 

            if (upperRightCoordinates is not null)
            {
                inputArr = upperRightCoordinates.Split(' ');
               

            }
            return inputArr;
        }
       

      
    }
}
