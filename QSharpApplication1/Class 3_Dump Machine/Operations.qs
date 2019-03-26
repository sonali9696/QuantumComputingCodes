namespace Quantum.DumpMechine
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Diagnostics;
    
    operation HelloQ () : Unit {
        Message("Hello quantum world!");
		
		mutable c = 0;
		for(i in 1..10)
		{
			
			using(qubits = Qubit[1])
			{
			
				DumpMachine("");
				H(qubits[0]);
				DumpMachine("");

				let result = M(qubits[0]);
				Message($"{result}");
				DumpMachine("");

				//X(qubits[0]);
				//DumpMachine("");

				//Y(qubits[0]);
				//DumpMachine("");

				//Z(qubits[0]);
				//DumpMachine("");
				
				
				//H(qubits[0]);
				//DumpMachine("");
				
				
				
				ResetAll(qubits); 



			}

		}

	}
}
