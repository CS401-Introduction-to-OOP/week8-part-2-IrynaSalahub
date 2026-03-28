namespace Week8;

public class BoxingTester
{
    public static void BoxingTest()
    {
        int a = 10;
        object boxedA = a;
        int unboxedA = (int)boxedA;
        
        Console.WriteLine($"Original a: {a}");
        Console.WriteLine($"Boxed value: {boxedA}");
        Console.WriteLine($"Unboxed value: {unboxedA}");

        a = 20;
        Console.WriteLine($"Originakl  --> {a}");
        Console.WriteLine($"Boxed balue --> {boxedA}");
    }

}