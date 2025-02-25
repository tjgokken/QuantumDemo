namespace QuantumQsharp {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    operation FlipQubit() : Result {
        // Allocate one qubit
        use qubit = Qubit();

        // Apply the Hadamard gate
        H(qubit);

        // Measure the qubit
        let result = M(qubit);

        // Reset the qubit to |0>
        Reset(qubit);

        // Return the measured result
        return result;
    }
}