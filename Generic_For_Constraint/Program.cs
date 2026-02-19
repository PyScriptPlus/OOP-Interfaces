namespace Generic_For_Constraint
{
    internal class Program
    {
        // Ta'rif Generic Constraint:
        // Mahdud kardan no'ei ke mitavand jaygozin T shavad
        // Faghat anvae khasi ghabel estefade bashad
        // Mesal mikhaym begim Faghat Class ha
        // Faghat Value Type ha
        // Faghat Reference Type ha
        // Faghat Class hayi ke yek Interface darand
        // Va ...........
        static void Main(string[] args)
        {
            Reference_Types<string> swap = new()
            {
                name1 = "Mohammad",
                name2 = "Reza"
            };
            swap.Swap(ref swap.name1, ref swap.name2);

            // Reference_Types<int> Error = new(); // Error mide faghat Reference Type ha mitunand


            //-------------------------------------------//

            Value_Types<double> change = new()
            {
                num1 = 10.1,
                num2 = 0.2
            };
            change.Swap(ref change.num1, ref change.num2);
            
        }
    }
}
