namespace Generic_for_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<string,int> @MyClass = new();
            MyClass.myProp = 50;
            Console.WriteLine(MyClass.myValue = "Number is: " + MyClass.myProp);

        }
    }
}
