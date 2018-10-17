using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
namespace Quantum.QuantumGates
{
    class Driver
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please choose number of Qubits");
            int numberofqubits = System.Convert.ToInt32(System.Console.ReadLine());
            int numberofquantumstates = (int)System.Math.Pow(2, numberofqubits);
            System.Console.WriteLine("Number of possible states in Quantum are {0}", numberofquantumstates);

            switch (numberofqubits)
            {
                case 1:
                    System.Console.WriteLine("Please choose X for flip Gate");
                    System.Console.WriteLine("Please choose H for applying Handamard Gate");
                    System.Console.WriteLine("Please choose XH for bit flip and then Handamard gate or choose HH for applytinh hadamard gate 2 times");
                    System.Console.WriteLine("Please choose the order of gates you want to apply");
                    string gatesorder = System.Console.ReadLine();
                    foreach(char gate in gatesorder)
                    {
                        System.Console.WriteLine(gate);
                    }
                    Result[] results1 = new Result[numberofquantumstates];
                    for (int i=0;i<numberofquantumstates;i++)
                    {
                        if(i == 0)
                        {
                            results1[i] = Result.Zero;
                        }
                        else
                        {
                            results1[i] = Result.One;
                        }
                    }
                    using (var sim = new QuantumSimulator())
                    {
                        
                        long res1;
                        
                        foreach (Result initial in results1)
                        {
                            res1 = Q1NOT.Run(sim, initial).Result;

                            System.Console.WriteLine(res1);


                        }
                     
                        System.Console.ReadLine();

                    }
                    break;
                case 2:
                    Result[,] results2 = new Result[numberofquantumstates, numberofqubits];
                    //for(int i=0;i< numberofquantumstates; i++)
                    //{
                    //    for(int j=0;j<numberofqubits;j++)
                    //    {
                    //        if(j==0)
                    //        {
                    //            results2[i, j] = Result.Zero;
                    //        }
                    //        else
                    //        {
                    //            results2[i, j] = Result.One;
                    //        }
                    //    }
                    //}
                    results2[0, 0] = Result.Zero;
                    results2[0, 1] = Result.Zero;
                    results2[1, 0] = Result.Zero;
                    results2[1, 1] = Result.One;
                    results2[2, 0] = Result.One;
                    results2[2, 1] = Result.Zero;
                    results2[3, 0] = Result.One;
                    results2[3, 1] = Result.One;
                  
                    using (var sim = new QuantumSimulator())
                    {
                        for (int i = 0; i < numberofquantumstates; i++)
                        {
                            
                                var res2 = Q2CNOT.Run(sim, results2[i,0], results2[i, 1]).Result;
                                System.Console.WriteLine(res2);
                                
                            
                        }
                    }
                    System.Console.ReadLine();
                    break;
            }
            
        }    
    }
    
}