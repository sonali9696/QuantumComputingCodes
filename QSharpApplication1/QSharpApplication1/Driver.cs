using System;





using Microsoft.Quantum.Simulation.Core;

using Microsoft.Quantum.Simulation.Simulators;





namespace Quantum.QSharpApplication1

{

    class Driver

    {

        static void Main(string[] args)

        {

            using (var quantumSimulator = new QuantumSimulator())

            {

                var result = HelloQ.Run(quantumSimulator).Result;

            }

            Console.WriteLine("Done");

            Console.ReadLine();

        }

    }

}