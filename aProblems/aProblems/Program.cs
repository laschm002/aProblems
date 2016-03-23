using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1 problem1 = new Problem1();
            problem1.computeLength("luke");

            Problem2 pie = new Problem2();
            pie.getPi();

            Problem3 moves = new Problem3();
            moves.instructions("Up");
            moves.instructions("Down");
            moves.instructions("Left");
            moves.instructions("Left");
            moves.instructions("Right");
            moves.instructions("Right");
            moves.instructions("Down");
            moves.instructions("Spin");
            moves.instructions("Down");
            moves.instructions("Up");
            moves.instructions("Left");
            moves.instructions("Right");
            moves.instructions("Left");
            moves.instructions("Down");
            moves.instructions("Spin");
            moves.instructions("Up");
            moves.instructions("Down");
            moves.instructions("Jump");

       Problem5 problem5 = new Problem5();
            problem5.dancer();
            problem5.ArmDown();






            Console.ReadLine();

        }
    }
}
