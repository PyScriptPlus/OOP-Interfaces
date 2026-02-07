namespace Non_generic_practice_with_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Non-Generic hast
            // Chand ta moshkel darad
            // 1- Hatman bayad Cast koni vagarne 100% be Error mikhori
            // 2- Type safety nadare
            // 3- Ehtemal Error Run-Time ro dare
            System.Collections.Hashtable HS = new();
            HS.Add("Key1", "Mohammad");
            HS[2] = "Ahbar";
            HS.Add("AmirHossein", 9);

            // Kar mikone dar Run-Time value moshkhas mishe
            Console.WriteLine(HS["Key1"]); // Output --> Mohammad

            // Vali hala biaym yek Operation dar Compile-Time anjam bedim
            // Error Compile-Time mide mesal:
            var num1 = HS["AmirHossein"];
            Console.WriteLine(num1);
            // int num2 = num1 + 6; // Error Compile-Time

            var num3 = (int)HS["AmirHossein"]!; // Cast kardam
            int num4 = num3 + 9; // Output --> 18

        }
    }
}
