#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/soagraw/source/repos/QUANTUM%20COMPUTING/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QSharpApplication1\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/soagraw/source/repos/QUANTUM%20COMPUTING/QSharpApplication1/QSharpApplication1/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QSharpApplication1
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum.QSharpApplication1.HelloQ";
        protected Allocate Allocate
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 9 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            Message.Apply("Hello world");
#line 11 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            var c = 0L;
#line 13 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
            foreach (var i in new Range(1L, 1000L))
#line hidden
            {
#line hidden
                {
#line 16 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    var qubits = Allocate.Apply(1L);
#line 19 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    var r = M.Apply(qubits[0L]);
#line 21 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    Message.Apply(String.Format("{0}", r));
#line 36 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
#line 37 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 39 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    var result = M.Apply(qubits[0L]);
#line 41 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    Message.Apply(String.Format("{0}", result));
#line 51 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    if ((result == Result.Zero))
                    {
#line 55 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                        c = (c + 1L);
                    }

#line 63 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    Message.Apply(String.Format("{0}", result));
#line 65 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                    ResetAll.Apply(qubits?.Copy());
#line hidden
                    Release.Apply(qubits);
                }

#line 73 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\QSharpApplication1\\Operations.qs"
                Message.Apply(String.Format("{0}", c));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}