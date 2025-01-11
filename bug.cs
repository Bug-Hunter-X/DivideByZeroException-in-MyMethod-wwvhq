public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; // Correct: handles a == 0
        }
        if (b == 0) {
            return a; // Correct: handles b == 0
        }
        return a / b; // Bug: potential for DivideByZeroException
    }
}