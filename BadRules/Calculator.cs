namespace BadRulesProject;

public class Calculator
{
    public int Add(int a, int b)    
    {
        return a + b;
    }
    
    public int Add2(int a, int b)    
    {
        return a + b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Cannot divide by zero!");

        return a / b;
    }
    
    public int Divide2(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Cannot divide by zero!");

        return a / b;
    }
}