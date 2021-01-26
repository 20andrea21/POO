using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1=7;
            int N2=6;
            int Suma=N1+N2;
            int Resta=N1-N2;
            int Multiplicacion=N1*N2;
            double Division=N1/N2;

            string[] MiListaNombre= new string[5] {"Eugenio","Emma","Lorenzo","Ricardo","Veronica"};

            Console.WriteLine("La Suma es igual a: "+Suma);
            Console.WriteLine("La Resta es igual a: "+Resta);
            Console.WriteLine("La Multiplicación es igual a: "+Multiplicacion);
            Console.WriteLine("La División es igual a: "+Division);

            for (int i=0; i<5; i++)
            {
                Console.WriteLine(MiListaNombre[i]);
            }

            for (int i=0; i<5; i++)
            {
                if (MiListaNombre[i]=="Emma")
                {
                   Console.WriteLine(MiListaNombre[i]+" sos la ganadora!");   
                }
                else
                {
                Console.WriteLine(MiListaNombre[i]);
                }
            }
        }
    }
}
