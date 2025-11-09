using System.ComponentModel.Design;
using System.Xml.Schema;

namespace eserziArray7_10
{
    internal class Program
    {
        //7
        static void Main(string[] args)
        {
            int[] vet = { 1, 2, 5, 10, 7, 6, 13};

            int a, b, cont = 0;

            Console.WriteLine("Inserisci il primo estremo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo estremo");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vet.Length; i++) {

                if (vet[i]>=a && vet[i]<=b) {

                    cont = cont + 1;
                
                }
            
            }

            Console.WriteLine("Numeri compresi: " + cont);

            Console.WriteLine();

            //8

            int[] vet1 = { 1, 2, 5, 10, 7, 6, 13 };

            int cont1 = 0;

            Console.WriteLine("Inserisci il primo estremo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo estremo");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vet1.Length; i++)
            {

                if (vet1[i] <= a || vet1[i] >= b)
                {

                    cont1 = cont1 + 1;

                }

            }

            Console.WriteLine("Numeri non compresi: " + cont1);

            Console.WriteLine();

            // 9

            int[] vet3 = { 3, 8, 5, 9, 12, 1 };

            int c, d, cont2 = 0;

            Console.WriteLine("Dimmi il primo estremo del primo intervallo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo estremo del primo intervallo");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il primo estremo del secondo intervallo");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo estremo del secondo intervallo");
            d = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vet3.Length; i++) {

                if (vet3[i]>=a &&  vet3[i]<=b || vet3[i] >=c && vet3[i]<=d)
                {
                    cont2 = cont2 + 1;
                }
            
            }

            Console.WriteLine("Numeri tra a-b oppure c-d: " + cont2);

            Console.WriteLine();

            //10

            int[] vet4 = { 3, 8, 5, 9, 12, 1 };

            int  cont3 = 0;

            Console.WriteLine("Dimmi il primo estremo del primo intervallo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo estremo del primo intervallo");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il primo estremo del secondo intervallo");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi il secondo estremo del secondo intervallo");
            d = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vet4.Length; i++)
            {

                if (vet3[i] >= a && vet3[i] <= b || vet3[i] >= c && vet3[i] <= d)
                { 
                }
                else
                {
                    cont3 = cont3 + 1;
                }

            }

            Console.WriteLine("Numeri non compresi tra a-b oppure c-d: " + cont3);

        }
    }
}
