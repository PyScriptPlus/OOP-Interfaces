namespace myProject;

internal class Program
{
    static void Main()
    {
        print();
    }
    public static void print()
    {
        var std = new Student();
        string fname;
        string lname;

        std.name(out fname, out lname);
        Console.Write("Your firstName is: " + fname);
        Console.WriteLine(" And lastName is: " + lname);
        std.studentCode();
    }
}