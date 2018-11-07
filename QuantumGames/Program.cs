using System;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumGames
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            do
            {
                j++;
                const int trialCount = 20000;
                Random generator = new Random();

                using (QuantumSimulator sim = new QuantumSimulator())
                {
                    int classicalWinCount = 0;
                    int quantumWinCount = 0;
                    int classicalAliceBobWinCount = 0;
                    int classicalJohnMikeWinCount = 0;
                    int quantumAliceBobWinCount = 0;
                    int quantumJohnMikeWinCount = 0;
                    int classicalnowincount = 0;
                    int quantumnowincount = 0;
                    for (int i = 0; i < trialCount; i++)
                    {
                        bool aliceBit = GetRandomBit(generator);
                        bool bobBit = GetRandomBit(generator);
                        bool johnBit = GetRandomBit(generator);
                        bool mikeBit = GetRandomBit(generator);
                        bool aliceMeasuresFirst = GetRandomBit(generator);
                        bool[] classicalXor =
                            PlayClassicalStrategy(aliceBit, bobBit, johnBit, mikeBit);
                        bool[] quantumXor =
                            PlayQuantumStrategy.Run(
                                sim,
                                aliceBit,
                                bobBit,
                                johnBit,
                                mikeBit,
                                aliceMeasuresFirst).Result.ToArray();

                        if ((aliceBit && bobBit) == !classicalXor[0])
                        {
                            classicalWinCount++;
                            classicalAliceBobWinCount++;
                        }
                        else if ((johnBit && mikeBit) == !classicalXor[1])
                        {
                            classicalWinCount++;
                            classicalJohnMikeWinCount++;
                        }
                        else
                        {
                            classicalnowincount++;
                        }
                        if ((aliceBit && bobBit) == !quantumXor[0])
                        {
                            quantumWinCount++;
                            quantumAliceBobWinCount++;
                        }
                        else if ((johnBit && mikeBit) == !quantumXor[1])
                        {
                            quantumWinCount++;
                            quantumJohnMikeWinCount++;
                        }
                        else
                        {
                            quantumnowincount++;
                        }
                    }

                    Console.WriteLine(
                        "Classical success rate: "
                        + classicalWinCount / (float)trialCount);
                    Console.WriteLine("Classical Alice and Bob won {0} times ", classicalAliceBobWinCount);
                    Console.WriteLine("Classical John and Mike won {0} times ", classicalJohnMikeWinCount);
                    Console.WriteLine("Classical did not win {0} times ", classicalnowincount);
                    Console.WriteLine();
                    Console.WriteLine(
                        "Quantum success rate: "
                        + quantumWinCount / (float)trialCount);
                    Console.WriteLine("Quantum Alice and Bob won {0} times ", quantumAliceBobWinCount);
                    Console.WriteLine("Quantum John and Mike won {0} times ", quantumJohnMikeWinCount);
                    Console.WriteLine("Quantum did not win {0} times ", quantumnowincount);
                    Console.WriteLine();

                    if (quantumWinCount > classicalWinCount)
                    {
                        Console.WriteLine("Round {0} Quantum Win ",j);
                    }
                    else
                    {
                        Console.WriteLine("Round {0} Classical Win ", j);
                    }

                }
                Console.WriteLine();
            } while (j < 10);
            Console.WriteLine();
            Console.WriteLine("All rounds completed");
            Console.ReadLine();
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
        private static bool[] PlayClassicalStrategy(bool aliceBit, bool bobBit, bool johnBit,bool mikeBit)
        {
            bool aliceOutput = false;
            bool bobOutput = false;
            bool johnOutput = false;
            bool mikeOutput = false;
            bool[] result = new bool[2];
            result[0] = aliceOutput == bobOutput;
            result[1] = johnOutput == mikeOutput;
            return result;


        }
    }
}
