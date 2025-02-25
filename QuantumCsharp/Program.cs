
using Microsoft.Quantum.Simulation.Simulators;
using QuantumQsharp; // Make sure this matches the Q# namespace

namespace QuantumCsharp;
class Program
{
    static void Main(string[] args)
    {
        using var sim = new QuantumSimulator();
        
        // Run the quantum operation 10 times
        for (int i = 0; i < 10; i++)
        {
            var result = FlipQubit.Run(sim).Result;
            Console.WriteLine($"Run {i + 1}: We got {result}");
        }
    }
}
