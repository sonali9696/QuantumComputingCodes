#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Class_4_CNOT_gate\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/soagraw/source/repos/QUANTUM%20COMPUTING/QSharpApplication1/Class%204_CNOT%20gate/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Class_4_CNOT_gate\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/soagraw/source/repos/QUANTUM%20COMPUTING/QSharpApplication1/Class%204_CNOT%20gate/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Class_4_CNOT_gate
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum.Class_4_CNOT_gate.HelloQ";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 8 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
            Message.Apply("Hello quantum world!");
#line 10 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
            var c = 0L;
#line 11 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
            foreach (var i in new Range(1L, 1L))
#line hidden
            {
#line hidden
                {
#line 13 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var qubits = Allocate.Apply(2L);
#line 17 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var result = M.Apply(qubits[0L]);
#line 18 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var result2 = M.Apply(qubits[1L]);
#line 20 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply("Initial");
#line 22 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply(String.Format("{0}", result));
#line 23 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply(String.Format("{0}", result2));
#line 26 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 28 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 30 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply("After entanglement");
#line 32 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var result3 = M.Apply(qubits[0L]);
#line 33 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var result4 = M.Apply(qubits[1L]);
#line 34 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply(String.Format("{0}", result3));
#line 35 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply(String.Format("{0}", result4));
#line 38 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
#line 40 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply("X gate on only 1st qubit");
#line 42 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var result5 = M.Apply(qubits[0L]);
#line 43 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    var result6 = M.Apply(qubits[1L]);
#line 44 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply(String.Format("{0}", result5));
#line 45 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
                    Message.Apply(String.Format("{0}", result6));
#line 50 "C:\\Users\\soagraw\\source\\repos\\QUANTUM COMPUTING\\QSharpApplication1\\Class 4_CNOT gate\\Operations.qs"
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