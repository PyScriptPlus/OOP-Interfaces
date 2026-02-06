namespace Interface_simulation
{
    public enum myColor
    {
        brown,
        black,
        white
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal anim = new();
            anim.dogAdjective(4, "Luky", myColor.black);
        }
    }
}
