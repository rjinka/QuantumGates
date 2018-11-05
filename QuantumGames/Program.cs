using System;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumGames
{
    

    class Program
    {
        static void Main(string[] args)
        {
            const int trialCount = 10000;
            Random generator = new Random();

            using (QuantumSimulator sim = new QuantumSimulator())
            {
                int classicalWinCount = 0;
                int quantumWinCount = 0;
                for (int i = 0; i < trialCount; i++)
                {
                    bool aliceBit = GetRandomBit(generator);
                    bool bobBit = GetRandomBit(generator);
                    bool johnBit = GetRandomBit(generator);                    
                    bool aliceMeasuresFirst = GetRandomBit(generator);
                    bool classicalXor =
                        !PlayClassicalStrategy(aliceBit, bobBit, johnBit);                   
                    bool quantumXor =
                        !PlayQuantumStrategy.Run(
                            sim,
                            aliceBit,
                            bobBit,
                            johnBit,                           
                            aliceMeasuresFirst).Result;

                    if ((aliceBit && bobBit && johnBit) == classicalXor)
                    {
                        classicalWinCount++;
                    }
                    if ((aliceBit && bobBit && johnBit) == quantumXor)
                    {
                        quantumWinCount++;
                    }
                }

                Console.WriteLine(
                    "Classical success rate: "
                    + classicalWinCount / (float)trialCount);
                Console.WriteLine(
                    "Quantum success rate: "
                    + quantumWinCount / (float)trialCount);

                if (quantumWinCount > classicalWinCount)
                {
                    Console.WriteLine("Quantum Win");
                }
                else
                {
                    Console.WriteLine("Classical Win");
                }
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Generates a single random bit.
        /// </summary>
        /// <param name="generator">An initialized RNG.</param>
        /// <returns>A single random bit, as a bool.</returns>
        private static bool GetRandomBit(Random generator)
        {
            int next = generator.Next();
            return (next & 1) == 1;
        }

        /// <summary>
        /// Plays the optimal classical strategy for the CHSH game:
        /// both Alice and Bob both always output 0. This should result
        /// in success 75% of the time.
        /// </summary>
        /// <param name="aliceBit">The bit given to Alice (X).</param>
        /// <param name="bobBit">The bit given to Bob (Y).</param>
        /// <returns>Whether Alice and Bob's output bits match.</returns>
        private static bool PlayClassicalStrategy(bool aliceBit, bool bobBit, bool johnBit)
        {
            bool aliceOutput = false;
            bool bobOutput = false;
            bool johnOutput = false;
            //return aliceOutput == bobOutput;

            if (aliceOutput == bobOutput)
            {
                return aliceOutput == johnOutput;
            }            
			else
			{
                return bobOutput == johnOutput;
            }
        }
    }
}
