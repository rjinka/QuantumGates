#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("QuantumGates", "Q1NOT () : ()", new string[] { }, "C:\\Projects\\Quantum\\QuantumGates\\QuantumGates\\Q1NOT.qs", 136L, 7L, 5L)]
#line hidden
namespace QuantumGates
{
    public class Q1NOT : Operation<QVoid, QVoid>, ICallable
    {
        public Q1NOT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Q1NOT";
        String ICallable.FullName => "QuantumGates.Q1NOT";
        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Q1NOT, QVoid, QVoid>(QVoid.Instance);
        }
    }
}