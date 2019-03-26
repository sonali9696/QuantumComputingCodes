using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Class_4_CNOT_gate
{
    class Driver
    {
        static void Main(string[] args)
        {
            //using (var qsim = new QuantumSimulator())
            //{
            //    HelloQ.Run(qsim).Wait();
            //}

            using (var quantumSimulator = new QuantumSimulator())
            {
                var result = HelloQ.Run(quantumSimulator).Result;
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}