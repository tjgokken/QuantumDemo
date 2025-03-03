# QuantumCoinFlip

## 🎲 Flipping Qubits: C# in Quantum Computing

This project demonstrates **quantum superposition** using **Q# and C#**. It simulates a quantum coin flip using the **Hadamard gate**, showcasing how quantum mechanics enables randomness at a fundamental level.

## 🚀 Project Overview

### What This Project Does:
- Uses **Q#** to flip a qubit using the **Hadamard gate** (H-gate).
- Measures the qubit to collapse it into a classical **0 or 1** state.
- Calls the quantum operation from a **C# console application**.
- Runs the experiment **10 times** to showcase randomness.

## 📂 Project Structure
```
QuantumCoinFlip/
│── QuantumQsharp/         # Q# project for quantum simulation
│   ├── QuantumCoinFlip.qs  # Q# file implementing the Hadamard operation
│── QuantumCsharp/         # C# console app to invoke Q# operations
│   ├── Program.cs         # Runs the Q# quantum flip operation 10 times
│── README.md              # Project documentation
│── QuantumCoinFlip.sln    # Solution file
```

## ⚡ Setup & Running the Project

### 1️⃣ Prerequisites
- **.NET SDK** (latest version) - [Download Here](https://dotnet.microsoft.com/en-us/download)
- **Microsoft Quantum Development Kit (QDK)** - [Setup Guide](https://learn.microsoft.com/en-us/azure/quantum/install-overview-qdk)
- **VS Code with Q# Extension** (for Q# development)

### 2️⃣ Clone the Repository
```sh
git clone https://github.com/tjgokken/QuantumDemo.git
cd QuantumCoinFlip
```

### 3️⃣ Run Quantum Flip (Q#)
```sh
dotnet run --project QuantumQsharp
```

### 4️⃣ Run C# Console Application
```sh
dotnet run --project QuantumCsharp
```

## 🔬 How It Works
### **Quantum Operation (Q#) - `QuantumCoinFlip.qs`**
```qsharp
namespace QuantumQsharp {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    operation FlipQubit() : Result {
        use qubit = Qubit();
        H(qubit);
        let result = M(qubit);
        Reset(qubit);
        return result;
    }
}
```
#### **Breakdown:**
1. **Allocates a qubit** (`use qubit = Qubit();`)
2. **Applies Hadamard gate (H-gate)** to put it into **superposition**
3. **Measures the qubit**, collapsing it to **0 or 1**
4. **Resets** the qubit before releasing it
5. **Returns the result** to be used by C#

### **C# Console App - `Program.cs`**
```csharp
using Microsoft.Quantum.Simulation.Simulators;
using QuantumQsharp;

namespace QuantumCsharp;
class Program
{
    static void Main(string[] args)
    {
        using var sim = new QuantumSimulator();
        for (int i = 0; i < 10; i++)
        {
            var result = FlipQubit.Run(sim).Result;
            Console.WriteLine($"Run {i + 1}: We got {result}");
        }
    }
}
```
#### **Breakdown:**
1. Uses **QuantumSimulator** to simulate quantum execution.
2. Calls `FlipQubit()` **10 times**.
3. Outputs results to the console, showing quantum randomness.

## 🏆 Expected Output
```
Run 1: We got One
Run 2: We got Zero
Run 3: We got One
Run 4: We got Zero
Run 5: We got One
...
```
Each run results in either `0` or `1` with a **50/50 probability**, simulating a fair coin toss.

## 📖 Learn More
- **Blog Article**: [https://tjgokken.com/flipping-qubits-c-in-quantum-computing]
- **Hadamard Gate & Superposition**: [Quantum Computing Basics](https://learn.microsoft.com/en-us/azure/quantum/concepts-superposition)
- **Quantum Development Kit (QDK)**: [Microsoft Docs](https://learn.microsoft.com/en-us/azure/quantum)
- **Quantum Programming in Q#**: [Q# Docs](https://learn.microsoft.com/en-us/quantum/qsharp)

## 📜 License
This project is licensed under the **MIT License**.

## 🤝 Contributing
Feel free to submit **pull requests** or report **issues**!

## 🔗 Connect
📧 **Contact**: [tjgokken.com](https://tjgokken.com)
