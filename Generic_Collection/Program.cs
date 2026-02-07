namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.HashSet<int> unique = new();
            unique.Add(4);
            unique.Add(4);
            unique.Add(2);
            unique.Add(1);
            Console.WriteLine("Unique numbers: " + unique.Count); // Output --> 3
            // Chera 3 ta? chon adad 4 (2) bar tekrar shode
            // Pas tedad adad haye Unique 3 ta hast
            // Adad haye takrari hazf mikone

            //--------------------------------------------------//

            System.Collections.Generic.List<int> values = new();
            // Mesl arraye hast vali ba vizheghi haye khob va ghavi
            values.Add(10);
            values.Add(2);
            values.Add(50);
            foreach (var item in values)
            {
                Console.WriteLine("List: " + item);
            }




            //--------------------------------------------------//

            System.Collections.Generic.Stack<string> myData = new();
            // Khob in Stack --> LIFO hast: Last In First Output
            // Ya'ni Akharin vorudi avvalin khoruji hast !!!

            // Push --> Ezafe kardan yek عنصر be balaye Stack
            // Pop --> Hazf va bazgardandane عنصر balaye Stack
            // Peek --> Faghat baraye didan avvalin khoruji ke akharin vorudi hast
            // Count --> Tedad عناصر dakhel Stack

            myData.Push("AmirHossein");
            myData.Push("Ahbar");
            myData.Push("Mohammad");

            Console.WriteLine("Stack: " + myData.Peek());// Output --> Mohammad
            Console.WriteLine("Stack count: " + myData.Count);

            myData.Pop();
            Console.WriteLine("Stack: " + myData.Peek());// Output --> Ahbar
            Console.WriteLine("Stack count: " + myData.Count);

            //--------------------------------------------------//

            // Naghes!!!
            //System.Collections.Generic.Comparer<string> com = new();




            //--------------------------------------------------//

            // Yek Generic key-value collection hast
            // Shabih Hashtable vali Generic va Type-Safe hast
            // Va Key hash bayad Unique bashand
            // Niyazi be cast ham nadare
            // Chon moshakhas mikonim Type eshun chi bashe
            System.Collections.Generic.Dictionary<int,string> pairs = new();
            pairs.Add(0, "Mohammad");
            pairs[1] = "Ahbar";
            pairs.Add(2, "AmirHossein");

            string names = pairs[0] + "\n" + pairs[1] + "\n" + pairs[2];
            Console.WriteLine(names);

        }
    }
}
