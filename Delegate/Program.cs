namespace Delegate;

/*
    Alternatively, I can define a delegate with a matching signature to call the method indirectly. Note that
    the names of the parameters do not have to match. Only the types of parameters and return values
    must match, as shown in the following code: 
*/
delegate string myDelegatereturn(string msg);

internal class Program
{
    static void Main(string[] args)
    {
        MyClass cls = new();

        // Ba new() rasmi tar hast kamel ma'lome
        // explicit hast moshakhas mikone darud yek Instance
        // Az Delegate misazid
        myDelegatereturn? dl = new(cls.firstName);
        Console.WriteLine(dl("Mamad"));
        dl -= cls.firstName; // Delete firstName Function
        // Console.WriteLine(dl("Mamad")); // Error

        // Hala bedun new() Compiler khodesh mifahme 
        // Va khodesh match mikone
        dl += cls.lastName;
        // Invoke farghi nadare hamune faghat khanayi mibare bala
        // Miyad Function haro ejra mikone
        Console.WriteLine(dl.Invoke("Yousefi"));
        
        /*
            Yedune am BeginInvoke darim ke fargh dare 
            In miyad Delegate ro dar yek Thread dige ejra mikone
            Ta barname asli dar Thread asli ejra she 
            Ya'ni in BeginInvoke Ye kari mikone ta
            Delegate dar yek Thread jodagone ejra she
            Dige rabti be barname asli nadare
            Thread haye jodagone hastand
        */
        
    }
}

public class MyClass
{
    public string firstName(string msg)
    {
        return $"Your name is: {msg}";
    }

    // Lambda Function
    public string lastName(string msg) => msg;
}
