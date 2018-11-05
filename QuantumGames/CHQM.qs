namespace QuantumGames
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;

   

    operation MeasureAliceQbit(bit : Bool, qubit : Qubit) : (Result)
    {
        body
        {
            if (bit)
            {
                // Measure in sign basis if bit is 1
                return Measure([PauliX], [qubit]);
            }
            else
            {
                // Measure in computational basis if bit is 0
                return Measure([PauliZ], [qubit]);
            }
        }
    }

    operation MeasureBobQbit(bit : Bool, qubit : Qubit) : (Result)
    {
        body
        {
            if (bit)
            {
                // Measure in -π/8 basis if bit is 1
                let rotation = 2.0 * PI() / 8.0;
                Ry(rotation, qubit);
                return M(qubit);
            }
            else
            {
                // Measure in π/8 basis if bit is 0
                let rotation = -2.0 * PI() / 8.0;
                Ry(rotation, qubit);
                return M(qubit);
            }
        }
    }

	 operation MeasureJohnQbit(bit : Bool, qubit : Qubit) : (Result)
    {
        body
        {
            if (bit)
            {
                // Measure in sign basis if bit is 1
                return Measure([PauliY], [qubit]);
            }
            else
            {
                // Measure in computational basis if bit is 0
                return Measure([PauliZ], [qubit]);
            }
        }
    }



    operation PlayQuantumStrategy(
        aliceBit : Bool,
        bobBit : Bool,
		johnBit : Bool,		
        aliceMeasuresFirst : Bool)
        : (Bool)
    {
        body
        {
            mutable aliceResult = Zero;
            mutable bobResult = Zero;
			mutable JohnResult = Zero;
			mutable intersult = Zero;

            using (qubits = Qubit[3])
            {
                // Alice and Bob get one qubit each
                let aliceQbit = qubits[0];
                let bobQbit = qubits[1];
				let JohnQbit = qubits[2];
                // Entangle Alice & Bob's qubits
                H(aliceQbit);
                CNOT(aliceQbit, bobQbit);

				// Entangle Bob & John's qubits
                H(bobQbit);
                CNOT(bobQbit, JohnQbit);

                // Randomize who measures first
                if (aliceMeasuresFirst)
                {
                    set aliceResult = MeasureAliceQbit(aliceBit, aliceQbit);
                    set bobResult = MeasureBobQbit(bobBit, bobQbit);
					set JohnResult = M(JohnQbit);
                }
                else
                {
                    set bobResult = MeasureBobQbit(bobBit, bobQbit);
                    set aliceResult = MeasureAliceQbit(aliceBit, aliceQbit);
					set JohnResult = M(JohnQbit);
                }

                ResetAll(qubits);
            }

			if(aliceResult == bobResult)
			{
				
				return aliceResult == JohnResult ;
			}
			else
			{
				return bobResult == JohnResult ;
			}
			

            //return (aliceResult == bobResult);
        }
    }
}
