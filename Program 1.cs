using System; // It is same as import java.util.*
namespace Mainw{ //namespace is collection of classes
    class Main2{
        int length=5;
        int breadth=10;
        
    public void Display(){
        Console.WriteLine("length : {0} ",length); // If we do not write '{0}' when using comma',' the lenght will not be printed
        Console.WriteLine("breadth "+breadth); //The '+' is same as java
    }
    }
    class z{ // This class should be defined other than Main
        static void Main (String[] args) // We have to use '[]' before args because it will show errors, In java we can use both before & after
        {                                // In static void Main method the M in 'Main' should be capital as compared to java
            Main2 obj = new Main2();  // Creating an Object 
            obj.Display();
        }
    }
}
