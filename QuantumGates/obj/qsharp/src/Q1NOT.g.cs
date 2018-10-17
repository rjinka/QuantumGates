#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QuantumGates", "Set (Desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs", 167L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.QuantumGates", "Q1NOT (Initial : Result) : Int", new string[] { }, "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs", 356L, 21L, 5L)]
[assembly: OperationDeclaration("Quantum.QuantumGates", "Q2CNOT (Initial1 : Result, Initial2 : Result) : (Int, Int)", new string[] { }, "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs", 779L, 47L, 2L)]
#line hidden
namespace Quantum.QuantumGates
{
    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.QuantumGates.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in) =>
        {
            var (Desired,q1) = __in;
#line 11 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var current = M.Apply(q1);
#line 13 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            if ((Desired != current))
            {
#line 15 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result Desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((Desired, q1));
        }
    }

    public class Q1NOT : Operation<Result, Int64>, ICallable
    {
        public Q1NOT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q1NOT";
        String ICallable.FullName => "Quantum.QuantumGates.Q1NOT";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Result, Int64> Body => (__in) =>
        {
            var Initial = __in;
#line 24 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var finaloutput = 0L;
#line 26 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var Qubits = Allocate.Apply(1L);
#line 28 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            Set.Apply((Initial, Qubits[0L]));
#line 29 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            MicrosoftQuantumPrimitiveX.Apply(Qubits[0L]);
#line 31 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var res = M.Apply(Qubits[0L]);
#line 32 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            if ((res == Result.One))
            {
#line 34 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                finaloutput = 1L;
            }
            else
            {
#line 38 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                finaloutput = 0L;
            }

#line 40 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            Set.Apply((Result.Zero, Qubits[0L]));
#line hidden
            Release.Apply(Qubits);
#line 43 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            return finaloutput;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Quantum.QuantumGates.Set));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Result data) => new QTuple<Result>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Result Initial)
        {
            return __m__.Run<Q1NOT, Result, Int64>(Initial);
        }
    }

    public class Q2CNOT : Operation<(Result,Result), (Int64,Int64)>, ICallable
    {
        public Q2CNOT(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Result)>, IApplyData
        {
            public In((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Q2CNOT";
        String ICallable.FullName => "Quantum.QuantumGates.Q2CNOT";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Result,Result), (Int64,Int64)> Body => (__in) =>
        {
            var (Initial1,Initial2) = __in;
#line 50 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var first = 0L;
#line 51 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var second = 0L;
#line 52 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var Qubits = Allocate.Apply(2L);
#line 54 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            Set.Apply((Initial1, Qubits[0L]));
#line 55 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            Set.Apply((Initial2, Qubits[1L]));
#line 56 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((Qubits[0L], Qubits[1L]));
#line 57 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var res1 = M.Apply(Qubits[0L]);
#line 58 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            if ((res1 == Result.One))
            {
#line 60 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                first = 1L;
            }
            else
            {
#line 64 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                first = 0L;
            }

#line 66 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            var res2 = M.Apply(Qubits[1L]);
#line 67 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            if ((res2 == Result.One))
            {
#line 69 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                second = 1L;
            }
            else
            {
#line 73 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
                second = 0L;
            }

#line 75 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            Set.Apply((Result.Zero, Qubits[0L]));
#line 76 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            Set.Apply((Result.Zero, Qubits[1L]));
#line hidden
            Release.Apply(Qubits);
#line 78 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGates\\Q1NOT.qs"
            return (first, second);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Quantum.QuantumGates.Set));
        }

        public override IApplyData __dataIn((Result,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Result Initial1, Result Initial2)
        {
            return __m__.Run<Q2CNOT, (Result,Result), (Int64,Int64)>((Initial1, Initial2));
        }
    }
}