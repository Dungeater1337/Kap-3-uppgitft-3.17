using System;


namespace uppgift3_17
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("viket tal väljer du?");
            float tal1 = float.Parse(Console.ReadLine());

            Console.WriteLine("välj ett till tal");
            float tal2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Välj en katogori " + "addition, subtraktion, multiplikation och division" );
            string katogori = Console.ReadLine();    
            
            

           switch (katogori)
            {
                case "addition":
                    float svar = tal1 + tal2; 
                    Console.WriteLine("summan blir " + svar);
                    float.Parse(Console.ReadLine());  
                    break;

                case "subtraktion":
                    float svar2 = tal1 - tal2;
                    Console.WriteLine("differansed blir " + svar2);
                    break;

                case "multiplikation":
                    float svar3 = tal1 * tal2;
                    Console.WriteLine("produkten blir " + svar3);
                    break;

                case "division":
                    float svar4 = tal1 / tal2;
                    Console.WriteLine("kvoten blir "+ svar4);
                    break; 


            }
            

        }
    }
}