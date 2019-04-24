#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.GHZ\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/GITHUB/QuantumComputingCodes/QSharpApplication1/GHZ/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.GHZ\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/GITHUB/QuantumComputingCodes/QSharpApplication1/GHZ/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.GHZ
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum.GHZ.HelloQ";
        protected ICallable MicrosoftQuantumExtensionsDiagnosticsDumpMachine
        {
            get;
            set;
        }

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

        protected ICallable<String, QVoid> Message
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

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 8 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
            Message.Apply("Hello quantum world!");
#line hidden
            {
#line 10 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                var qubits = Allocate.Apply(6L);
#line 12 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 13 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 14 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[2L]));
#line 15 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[3L]));
#line 16 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[4L]));
#line 17 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[5L]));
#line 19 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                MicrosoftQuantumExtensionsDiagnosticsDumpMachine.Apply("");
#line 21 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\GHZ\\Operations.qs"
                ResetAll.Apply(qubits?.Copy());
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsDiagnosticsDumpMachine = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpMachine<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}