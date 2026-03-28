
using System.Resources;
using Week8;

class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 5, Y = 5 };
        Point p2 = p1; 
        
        p2.X = 10; 

        Console.Write("p1: "); p1.Print(); 
        Console.Write("p2: "); p2.Print(); 
        
        PointRef pr1 = new PointRef { X = 5, Y = 5 };
        PointRef pr2 = pr1;
        
        pr2.X = 10; 
    
        Console.Write("pr1: "); pr1.Print(); 
        Console.Write("pr2: "); pr2.Print(); 
    }
}
