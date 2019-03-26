namespace Quantum.Class_4_CNOT_gate
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Diagnostics;
    
    operation HelloQ () : Unit {
        Message("Hello quantum world!");

		mutable c = 0;
		for(i in 1..1)
		{
			using(qubits = Qubit[2])
			{
				//X(qubits[1]);
				
				let result = M(qubits[0]);
				let result2 = M(qubits[1]);

				Message("Initial");

				Message($"{result}");
				Message($"{result2}");
				//DumpMachine("");

				H(qubits[0]);

				CNOT(qubits[0], qubits[1]);

				Message("After entanglement");

				let result3 = M(qubits[0]);
				let result4 = M(qubits[1]);
				Message($"{result3}");
				Message($"{result4}");


				X(qubits[1]);
				//This breaks the entanglement
				Message("X gate on only 1st qubit");

				let result5 = M(qubits[0]);
				let result6 = M(qubits[1]);
				Message($"{result5}");
				Message($"{result6}");

				//DumpMachine("");


				ResetAll(qubits); 
			}
		}
    }
}
