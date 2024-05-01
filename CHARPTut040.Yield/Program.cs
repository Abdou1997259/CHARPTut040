namespace CHARPTut040.Yield
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Generatev3())
            {
                Console.Write(item);
                //MOVE NEXT GO TO BODY UNTIL RUN AGAINT THE FIRST YIELD AND YEILD DEFINE THE CURRENT VALUE AND RETURN TO THE CALLER
                //AND SCEOND MOVE NEXT WILL GO TO NEXT LINE  

            }
            Console.ReadKey();
        }
        public static IEnumerable<int> Generatev2()
        {
            for(int i=1; i<5; i++)
            {
                yield return i;
            }
        }
        public static IEnumerable<int> Generatev3()
        {
            
                yield return 1;
                yield return 2;
                yield return 3;
                yield return 4;
                yield return 5;
                yield break;
        }
    }
}