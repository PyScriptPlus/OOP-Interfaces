namespace Generic_For_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Mohammad";
            string name2 = "Reza";
            Swap(ref name1!, ref name2!);
        }

        // Mikham Function ba Generic benevisam
        // Mikham barname benevisam kar Swap ro anjam bede
        // Mitunestim be jaye void ham T bezarim vali on moghe bayad
        // return mikardim yek meghdar ro

        /*
            Out: 
            
        قبل از فرستادن می‌تواند مقدار نداشته باشد

        متد حتماً باید داخل خودش یک مقدار بدهد

        استفاده برای زمانی که می‌خواهی یک مقدار تازه بسازی و برگردانی 
         
        */

        /*
          ref:

         نیاز به مقدار اولیه قبل از فرستادن دارد

         متد می‌تواند مقدار را تغییر دهد یا نه   

         استفاده برای زمانی که می‌خواهی مقداری که قبلاً داری را تغییر بدهی
         
         */
        public static void Swap<T>(ref T? A, ref T? B)
        {
            T? temp = A;
            A = B;
            B = temp;
            Console.WriteLine(A + " " + B);
        }
    }
}