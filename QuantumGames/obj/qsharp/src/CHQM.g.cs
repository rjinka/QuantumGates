#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGames\",\"Name\":\"MeasureAliceQbit\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGames\",\"Name\":\"MeasureAliceQbit\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":10,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGames\",\"Name\":\"MeasureBobQbit\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":43}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGames\",\"Name\":\"MeasureBobQbit\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":27,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGames\",\"Name\":\"MeasureJohnQbit\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":46,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGames\",\"Name\":\"MeasureJohnQbit\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumGames\",\"Name\":\"PlayQuantumStrategy\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aliceBit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bobBit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":15}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"johnBit\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":3},\"Item2\":{\"Line\":4,\"Column\":10}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aliceMeasuresFirst\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":9},\"Item2\":{\"Line\":5,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"QuantumGames\",\"Name\":\"PlayQuantumStrategy\"},\"SourceFile\":\"C:/Projects/GitHub/QuantumGates/QuantumGames/CHQM.qs\",\"Position\":{\"Item1\":72,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace QuantumGames
{
    public class MeasureAliceQbit : Operation<(Boolean,Qubit), Result>, ICallable
    {
        public MeasureAliceQbit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "MeasureAliceQbit";
        String ICallable.FullName => "QuantumGames.MeasureAliceQbit";
        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Result> Body => (__in) =>
        {
            var (bit,qubit) = __in;
#line 13 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            if (bit)
            {
#line 16 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliX}, new QArray<Qubit>()
                {qubit}));
            }
            else
            {
#line 21 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubit}));
            }
        }

        ;
        public override void Init()
        {
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<MeasureAliceQbit, (Boolean,Qubit), Result>((bit, qubit));
        }
    }

    public class MeasureBobQbit : Operation<(Boolean,Qubit), Result>, ICallable
    {
        public MeasureBobQbit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "MeasureBobQbit";
        String ICallable.FullName => "QuantumGames.MeasureBobQbit";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Result> Body => (__in) =>
        {
            var (bit,qubit) = __in;
#line 30 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            if (bit)
            {
#line 33 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                var rotation = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 8D);
#line 34 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                MicrosoftQuantumPrimitiveRy.Apply((rotation, qubit));
#line 35 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return M.Apply(qubit);
            }
            else
            {
#line 40 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                var rotation = ((-(2D) * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 8D);
#line 41 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                MicrosoftQuantumPrimitiveRy.Apply((rotation, qubit));
#line 42 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return M.Apply(qubit);
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<MeasureBobQbit, (Boolean,Qubit), Result>((bit, qubit));
        }
    }

    public class MeasureJohnQbit : Operation<(Boolean,Qubit), Result>, ICallable
    {
        public MeasureJohnQbit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "MeasureJohnQbit";
        String ICallable.FullName => "QuantumGames.MeasureJohnQbit";
        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Result> Body => (__in) =>
        {
            var (bit,qubit) = __in;
#line 51 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            if (bit)
            {
#line 54 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliY}, new QArray<Qubit>()
                {qubit}));
            }
            else
            {
#line 59 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return Measure.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubit}));
            }
        }

        ;
        public override void Init()
        {
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<MeasureJohnQbit, (Boolean,Qubit), Result>((bit, qubit));
        }
    }

    public class PlayQuantumStrategy : Operation<(Boolean,Boolean,Boolean,Boolean), Boolean>, ICallable
    {
        public PlayQuantumStrategy(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Boolean,Boolean)>, IApplyData
        {
            public In((Boolean,Boolean,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PlayQuantumStrategy";
        String ICallable.FullName => "QuantumGames.PlayQuantumStrategy";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Result> MeasureAliceQbit
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Result> MeasureBobQbit
        {
            get;
            set;
        }

        public override Func<(Boolean,Boolean,Boolean,Boolean), Boolean> Body => (__in) =>
        {
            var (aliceBit,bobBit,johnBit,aliceMeasuresFirst) = __in;
#line 75 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            var aliceResult = Result.Zero;
#line 76 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            var bobResult = Result.Zero;
#line 77 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            var JohnResult = Result.Zero;
#line 78 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            var intersult = Result.Zero;
#line hidden
            {
#line 80 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                var qubits = Allocate.Apply(3L);
#line 83 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                var aliceQbit = qubits[0L];
#line 84 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                var bobQbit = qubits[1L];
#line 85 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                var JohnQbit = qubits[2L];
#line 87 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                MicrosoftQuantumPrimitiveH.Apply(aliceQbit);
#line 88 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((aliceQbit, bobQbit));
#line 91 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                MicrosoftQuantumPrimitiveH.Apply(bobQbit);
#line 92 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((bobQbit, JohnQbit));
#line 95 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                if (aliceMeasuresFirst)
                {
#line 97 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                    aliceResult = MeasureAliceQbit.Apply((aliceBit, aliceQbit));
#line 98 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                    bobResult = MeasureBobQbit.Apply((bobBit, bobQbit));
#line 99 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                    JohnResult = M.Apply(JohnQbit);
                }
                else
                {
#line 103 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                    bobResult = MeasureBobQbit.Apply((bobBit, bobQbit));
#line 104 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                    aliceResult = MeasureAliceQbit.Apply((aliceBit, aliceQbit));
#line 105 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                    JohnResult = M.Apply(JohnQbit);
                }

#line 108 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line 111 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
            if ((aliceResult == bobResult))
            {
#line 114 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return (aliceResult == JohnResult);
            }
            else
            {
#line 118 "C:\\Projects\\GitHub\\QuantumGates\\QuantumGames\\CHQM.qs"
                return (bobResult == JohnResult);
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MeasureAliceQbit = this.Factory.Get<ICallable<(Boolean,Qubit), Result>>(typeof(MeasureAliceQbit));
            this.MeasureBobQbit = this.Factory.Get<ICallable<(Boolean,Qubit), Result>>(typeof(MeasureBobQbit));
        }

        public override IApplyData __dataIn((Boolean,Boolean,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean aliceBit, Boolean bobBit, Boolean johnBit, Boolean aliceMeasuresFirst)
        {
            return __m__.Run<PlayQuantumStrategy, (Boolean,Boolean,Boolean,Boolean), Boolean>((aliceBit, bobBit, johnBit, aliceMeasuresFirst));
        }
    }
}