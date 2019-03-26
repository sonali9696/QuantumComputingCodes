#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DumpMechine\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/soagraw/source/repos/QUANTUM%20COMPUTING/QSharpApplication1/Class%203_Dump%20Machine/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DumpMechine\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/soagraw/source/repos/QUANTUM%20COMPUTING/QSharpApplication1/Class%203_Dump%20Machine/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.DumpMechine
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum.DumpMechine.HelloQ";
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
#line 8 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
            Message.Apply("Hello quantum world!");
#line 10 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
            var c = 0L;
#line 11 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
            foreach (var i in new Range(1L, 10L))
#line hidden
            {
#line hidden
                {
#line 14 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    var qubits = Allocate.Apply(1L);
#line 17 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpMachine.Apply("");
#line 18 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 19 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpMachine.Apply("");
#line 21 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    var result = M.Apply(qubits[0L]);
#line 22 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    Message.Apply(String.Format("{0}", result));
#line 23 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
                    MicrosoftQuantumExtensionsDiagnosticsDumpMachine.Apply("");
#line 40 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 3_Dump Machine\\Operations.qs"
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
            this.MicrosoftQuantumExtensionsDiagnosticsDumpMachine = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpMachine<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
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