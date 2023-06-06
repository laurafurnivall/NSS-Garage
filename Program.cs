using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicles> electricVehicles = new List<IElectricVehicles>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"CurrentlY {ev.CurrentChargePercentage}% charged.");
            }

            foreach (IElectricVehicles ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"Now {ev.CurrentChargePercentage}% charged.");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>() {
                ram, cessna150
            };
            Console.WriteLine();
            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"Currently: {gv.CurrentTankPercentage}% full.");
            }

            foreach (IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"Now {gv.CurrentTankPercentage}% full!");
            }
        }
    }
}