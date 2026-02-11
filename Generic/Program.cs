namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> integerBox = new();
            Console.WriteLine(integerBox.value = 18);

            Box<double> floatingPointBox = new();
            Console.WriteLine(floatingPointBox.value = 12.6); 

            Box<string> stringBox = new();
            Console.WriteLine(stringBox.value = "Mohammad");

            Box<float> floatBox = new();
            Console.WriteLine(floatBox.foo(36.2f));


            //----------------------------------------//

            MyClass cls = new();
            int number = cls.print(5);
            Console.WriteLine(number);
            
            cls.writeLine("Mohammad");

            //----------------------------------------//

            Factory<myPublic> factory = new Factory<myPublic>();
            myPublic @public = factory.Create();
        }
    }
    public class MyClass
    {
        // Generic Method
        public T print<T> (T value)
        {
            return value;
        }
        public void writeLine<T>(T Value)
        {
            Console.WriteLine(Value);
            return;
        }
    }

    
    class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
    public class myPublic
    {
        // Constructor
        public myPublic() 
        {
            Console.WriteLine("Hello World!");
        }

    }

}
