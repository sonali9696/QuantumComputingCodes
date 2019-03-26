#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Class_6_Detanglement\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/GITHUB/QuantumComputingCodes/QSharpApplication1/Class%206_Detanglement/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Class_6_Detanglement\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/GITHUB/QuantumComputingCodes/QSharpApplication1/Class%206_Detanglement/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Class_6_Detanglement
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum.Class_6_Detanglement.HelloQ";
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
#line 7 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
            Message.Apply("Hello quantum world!");
#line 8 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
            var c00 = 0L;
#line 9 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
            var c01 = 0L;
#line 10 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
            var c10 = 0L;
#line 11 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
            var c11 = 0L;
#line 13 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
            foreach (var i in new Range(1L, 1000L))
#line hidden
            {
#line hidden
                {
#line 15 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    var qubits = Allocate.Apply(2L);
#line 28 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 29 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 31 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 32 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 34 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    var result1 = M.Apply(qubits[0L]);
#line 35 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    var result2 = M.Apply(qubits[1L]);
#line 37 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    Message.Apply(String.Format("{0}, {1}", result1, result2));
#line 40 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    if (((result1 == Result.Zero) && (result2 == Result.Zero)))
                    {
#line 42 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                        c00 = (c00 + 1L);
                    }
                    else if (((result1 == Result.Zero) && (result2 == Result.One)))
                    {
#line 46 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                        c01 = (c01 + 1L);
                    }
                    else if (((result1 == Result.One) && (result2 == Result.Zero)))
                    {
#line 50 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                        c10 = (c10 + 1L);
                    }
                    else
                    {
#line 54 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                        c11 = (c11 + 1L);
                    }

#line 57 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    Message.Apply(String.Format("c00={0}, c01={1}, c10={2}, c11={3}", c00, c01, c10, c11));
#line 59 "C:\\GITHUB\\QuantumComputingCodes\\QSharpApplication1\\Class 6_Detanglement\\Operations.qs"
                    ResetAll.Apply(qubits?.Copy());
#line hidden
                    Release.Apply(qubits);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
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