public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it will reliably print 0
    }
} 