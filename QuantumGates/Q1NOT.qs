namespace Quantum.QuantumGates
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	
	  operation  Set(Desired: Result, q1:Qubit) : ()
    {
        body
        {
           
			let current = M(q1);

			if(Desired != current)
			{
				X(q1);
			}
        }
    }

    operation Q1NOT (Initial:Result) : (Int)
    {
        body
        {
		mutable finaloutput = 0;
		
		using(Qubits = Qubit[1])
		{
			Set(Initial,Qubits[0]);		
			X(Qubits[0]);
			
			let res = M(Qubits[0]);
			if(res == One)
			{
				set finaloutput = 1;
			}
			else
			{
				set finaloutput = 0;
			}
			Set(Zero,Qubits[0]);

		}
        return finaloutput;
        }
    }
	operation Q2CNOT (Initial1:Result,Initial2:Result) : (Int,Int)
	{
		body
		{
			mutable first = 0;
			mutable second = 0;
			using(Qubits = Qubit[2])
			{
				Set(Initial1,Qubits[0]);
				Set(Initial2,Qubits[1]);
				CNOT(Qubits[0],Qubits[1]);
				let res1 = M(Qubits[0]);
				if (res1 == One)
				{
					set first = 1;
				}
				else
				{
					set first = 0;
				}
				let res2 = M(Qubits[1]);
				if(res2 == One)
				{
					set second = 1;
				}
				else
				{
					set second = 0;
				}
				Set(Zero,Qubits[0]);
				Set(Zero,Qubits[1]);
			}
			return (first,second);

		}
	}
}
