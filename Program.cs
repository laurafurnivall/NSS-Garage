using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram rammy = new Ram();

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();
            rammy.Drive();
            rammy.Turn("right");
            rammy.Stop();
        }
    }
}