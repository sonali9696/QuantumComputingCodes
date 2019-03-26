namespace Quantum.QSharpApplication1
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation HelloQ () : Unit 
    {     

        Message("Hello world");

        mutable c = 0;

        for(i in 1..1000)
        {
			//Qubit[1] means an array of 1 element (by default initialized to 0)
            using(qubits = Qubit[1])
            {
				// this means the first element of the array is measured
                let r = M(qubits[0]);

                Message($"{r}");

                // Applying Hadamard on the qubit

                //H(qubits[0]); // means applying H gate on the qbit
				
				//H(qubits[0]); // applying it twice: brings back the input i.e. 1000 zeros



				//Now trying with X gate
				//X(qubits[0]); //flips all zeros to 1 so 0 zeros
				//X(qubits[0]); // applying it twice means all will become 0 again i.e. 1000 zeros

				//now H on 1 i.e. first flip the 0 to 1 then apply H on it
				X(qubits[0]);
				H(qubits[0]);

                let result = M(qubits[0]); //the valus is replaced in the same variable

                Message($"{result}");

                //This output might change for every execution

                //because H will put the qubit in a 50/50 superposition of 0 and 1

                //Message(ToStringB(BoolFromResult(result)));

                

                if(result == Zero)

                {

                    set c = c+1;

                }


 


                Message ($"{result}");

                ResetAll(qubits); 

            }


 


            Message($"{c}");

        }

    }

}

 