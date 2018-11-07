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

	 operation MeasureMikeQbit(bit : Bool, qubit : Qubit) : (Result)
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


    operation PlayQuantumStrategy(
        aliceBit : Bool,
        bobBit : Bool,
		johnBit : Bool,	
		mikeBit : Bool,
        aliceMeasuresFirst : Bool)
        :Bool[]
    {
        body
        {
            mutable aliceResult = Zero;
            mutable bobResult = Zero;
			mutable JohnResult = Zero;
			mutable mikeResult = Zero;
			mutable intersult = Zero;
			mutable resultArray = new Bool[2];

            using (qubits = Qubit[4])
            {
                // Alice and Bob get one qubit each
                let aliceQbit = qubits[0];
                let bobQbit = qubits[1];
				let JohnQbit = qubits[2];
				let mikeQbit = qubits[3];
                // Entangle Alice & Bob's qubits
                H(aliceQbit);
                CNOT(aliceQbit, bobQbit);

				// Entangle john and mike
                H(JohnQbit);
                CNOT(JohnQbit, mikeQbit);

                // Randomize who measures first
                if (aliceMeasuresFirst)
                {
                    set aliceResult = MeasureAliceQbit(aliceBit, aliceQbit);
                    set bobResult = MeasureBobQbit(bobBit, bobQbit);
					set JohnResult = MeasureJohnQbit(johnBit,JohnQbit);
					set mikeResult = MeasureMikeQbit(mikeBit,mikeQbit);
					
                }
                else
                {
                    set bobResult = MeasureBobQbit(bobBit, bobQbit);
                    set aliceResult = MeasureAliceQbit(aliceBit, aliceQbit);
					set JohnResult = MeasureJohnQbit(johnBit,JohnQbit);
					set mikeResult = MeasureMikeQbit(mikeBit,mikeQbit);
                }

                ResetAll(qubits);
            }

			set resultArray[0] = aliceResult == bobResult;
			set resultArray[1] = JohnResult == mikeResult;
			

            return resultArray;
        }
    }
}
