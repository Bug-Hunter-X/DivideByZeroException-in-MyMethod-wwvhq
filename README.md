# C# DivideByZeroException Bug

This repository demonstrates a common C# bug: a potential `DivideByZeroException` in a simple mathematical function. The `MyMethod` function in `bug.cs` does not adequately handle the scenario where the divisor (`b`) is zero.

The solution, found in `bugSolution.cs`, addresses this by adding a check for `b` being zero before performing the division.