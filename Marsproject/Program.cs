
using Marsproject;
using System.Security.Cryptography.X509Certificates;

try
{
    string[] inputArr ;
    int X1, Y2, px1, py2,totalrover;
    char direction;
    Console.WriteLine("Enter total numbers of rovers");
    totalrover=Convert.ToInt32(Console.ReadLine());
    Takeinput obj = new Takeinput();
    obj.takeplateaucoordinates();
    inputArr = obj.plateauCoordinates.Split(' ');
    px1 = Convert.ToInt32(inputArr[0]);
    py2 = Convert.ToInt32(inputArr[1]);

    for (int i = 1; i <= totalrover; i++)
    {
        obj.takeUpperRightCoordinates();
        inputArr = obj.Seperateinput();
        obj.takeexplorePlateauInstructions();
        X1 = Convert.ToInt32(inputArr[0]);
        Y2 = Convert.ToInt32(inputArr[1]);
        direction = Convert.ToChar(inputArr[2]);
       marsrover marsroverobj = new marsrover(X1, Y2, direction, obj.explorePlateau, px1, py2);
        marsroverobj.Movement();
    }
  


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();
        
