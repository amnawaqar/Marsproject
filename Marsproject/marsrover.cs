using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject
{
    public class marsrover : Imarsover
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int PX1 { get; set; }
        public int PY1 { get; set; }
        public char Direction { get; set; }
        public string instructions { get; set; }


        public marsrover(int x1, int y2, char direction, string instructions,int px1,int py2)
        {
            X1 = x1;
            Y1 = y2;
            this.Direction = direction;
            this.instructions = instructions;
            PX1 = px1;
            PY1 = py2;
        }
        public void Movement()
        {
            foreach (char instruction in instructions)
            {
                if (instruction == 'L')
                {

                    turnLeft();
                }
                else if (instruction == 'R')
                {

                    turnRight();
                }
                else if (instruction == 'M')
                {

                    move();
                }
            }
            output();
        }
        public void turnRight()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'S';
                    break;
                case 'S':
                    Direction = 'W';
                    break;
                case 'W':
                    Direction = 'N';
                    break;
            }
        }

        public void turnLeft()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'W';
                    break;
                case 'W':
                    Direction = 'S';
                    break;
                case 'S':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'N';
                    break;
            }
        }
        public void move()
        {
            if (Direction == 'N' && Y1 < PY1)
            {
                Y1 = Y1 + 1;
            }
            else if (Direction == 'E' && X1 < PX1)
            {
                X1 = X1 + 1;
            }
            else if (Direction == 'S' && Y1 > 0)
            {
                Y1 = Y1 - 1;
            }
            else if (Direction == 'W' && X1 > 0)
            {
                X1 = X1 - 1;
            }
        }
        public void output()
        {
            Console.WriteLine("{0} {1} {2}", X1, Y1, Direction);
        }
    }
}

