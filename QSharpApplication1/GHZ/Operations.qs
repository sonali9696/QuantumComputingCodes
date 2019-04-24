namespace Quantum.GHZ
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Diagnostics;
    
    operation HelloQ () : Unit {
        Message("Hello quantum world!");

		using (qubits = Qubit[6])
		{
			H(qubits[0]);
			CNOT(qubits[0],qubits[1]);
			CNOT(qubits[0],qubits[2]);
			CNOT(qubits[0],qubits[3]);
			CNOT(qubits[0],qubits[4]);
			CNOT(qubits[0],qubits[5]);

			DumpMachine("");

			ResetAll(qubits);
		}
    }
}
