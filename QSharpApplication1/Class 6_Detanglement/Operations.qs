namespace Quantum.Class_6_Detanglement
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation HelloQ () : Unit {
        Message("Hello quantum world!");
		mutable c00 = 0;
		mutable c01 = 0;
		mutable c10 = 0;
		mutable c11 = 0;

		for (i in 1..1000)
		{
			using(qubits = Qubit[2])
			{
				//Case 0: with no gates - c00 = 1000
				
				//Case 1 - H on both: c00, c01, c10, c11 - equally distributed
				//H(qubits[0]);
				//H(qubits[1]);

				//Case 2 - Entangled - c00 and c11 - equally distributed
				//H(qubits[0]);
				//CNOT(qubits[0],qubits[1]);
				
				//Case 3 - Detanglement - all 1000 are Zeros again
				H(qubits[0]);
				CNOT(qubits[0],qubits[1]);
				
				CNOT(qubits[0],qubits[1]);
				H(qubits[0]);

				let result1 = M(qubits[0]);
				let result2 = M(qubits[1]);

				Message($"{result1}, {result2}");


				if(result1 == Zero && result2 == Zero)
				{
					set c00 = c00 + 1;
				}
				elif(result1 == Zero && result2 == One)
				{
					set c01 = c01 + 1;
				}
				elif(result1 == One && result2 == Zero)
				{
					set c10 = c10 + 1;
				}
				else
				{
					set c11 = c11 + 1;
				}

				Message ($"c00={c00}, c01={c01}, c10={c10}, c11={c11}");

				ResetAll(qubits); 
			}
		}
    }
}
