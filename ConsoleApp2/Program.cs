using System;


namespace ConsoleApp2
{

    class program
    {

        static void Main(string[] args)
        {

            /*
             * Zadanie 2.1
             */
            double stopnie_Celsjusza, stopnie_Fahrenheita;
            Console.WriteLine("Podaj stopnie Celsjusza:");
            stopnie_Celsjusza = Convert.ToDouble(Console.ReadLine());
            stopnie_Fahrenheita = 32 + (9 / 5 * stopnie_Celsjusza);
            Console.WriteLine("Stopnie Celsjusza:{0}  stopnie Fahrenheita:{1}", stopnie_Celsjusza, stopnie_Fahrenheita);

            /*
             * Zadanie 2.2
             */

            int a, b, c,delta,sqrt;
            Console.WriteLine("podaj wartość a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj wartość b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj wartość c:");
            c = Convert.ToInt32(Console.ReadLine());
            delta = (b * b) - 4 * a * c;
            sqrt = (int)Math.Sqrt(delta);
            if(sqrt > 0)
            {
                Console.WriteLine("miejsce zerowe 1:{0}", sqrt);
                Console.WriteLine("miejsce zerowe 2:-{0}", sqrt);
            }
            else if(sqrt == 0)
            {
                int solve1 = -b / 2 * a;
                Console.WriteLine("miejsce zerowe:{0}", solve1);
            }
            else
            {
                Console.WriteLine("Delta ujemna !");
            }

            /*
             *Zadanie 2.3 
             */
            double BMI, masa, wzrost;
            Console.WriteLine("Podaj mase ciala w kg:");
            masa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj wzrost:");
            wzrost = Convert.ToDouble(Console.ReadLine());
            BMI = masa / (wzrost * wzrost);
            Console.WriteLine("BMI wynosi:{0}", BMI);

            /*
             * Zadanie 2.4
             */
            Console.WriteLine("Zadanie 2.4 - odpowiedź :a, ponieważ do 100 dodana jest jedynka, nastepnie wynik 101 mnożymy przez 2");
            int x = 100;
            Console.WriteLine(++x * 2);

            /*
             * Zadanie 2.5
             */
            Console.WriteLine("Zadanie 2.5 - odpowiedź :d");
            int x2 = 2, y2 = 3;
            
            Console.WriteLine(x2 *= y2 * 2);

            /*
             * Zadanie 2.6
             */
            Console.WriteLine("Zadanie 2.6 - odpowiedź :3");
            int x3, y = 4;
            x3 = (y -= 2);
            x3 = y++;
            x3 = y--;
            Console.WriteLine(x3);

            /*
             * Zadanie 2.7
             */
            Console.WriteLine("Zadanie 2.6 - odpowiedź :7");
            int x4, y3 = 5;
            x4 = ++y3 * 2;
            x4 = y3++;
            x4 = y3--;
            Console.WriteLine(++y3);

            /*
             * Zadanie 2.8
             */

            Console.WriteLine("Zadanie 2.8 - odpowiedź :a");

            bool x5;
            int y4 = 1, z = 1;
            x5 = (y4 == 1 && z++ == 1);
            Console.WriteLine(x5);

            /*
             * Zadanie 2.9
             */

            Console.WriteLine("Zadanie 2.9 a)Fasle= x = 2, y=5, z=1");
            int x6 = 1, y5 = 4, z2 = 2;
            bool wynik = (x6++ > 1 && y5++ == 4 && z2-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x6, y4, z2);

            Console.WriteLine("Zadanie 2.9 b)False= x =2, y=5, z=1");
            int x7 = 1, y6 = 4, z3 = 2;
            bool wynik2 = (x7++ > 1 & y6++ == 4 && z3-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik2, x7, y6, z3);

            Console.WriteLine("Zadanie 2.9 c) False= x=2, y=5, z=1)");
            int x8 = 1, y7 = 4, z4 = 2;
            bool wynik3 = (x8++ > 1 & y7++ == 4 & z4-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik3, x8, y7, z4);

            Console.WriteLine("Zadanie 2.9 d) TRUE = x = 1,y=4, z= 5");
            int x9 = 1, y8 = 3, z5 = 4;
            bool wynik4 = (x9 == 1 || y8++ > 2 || ++z5 > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik4, x9, y8, z5);

            Console.WriteLine("Zadanie 2.9 e) TRUE = x=1, y=4, z=5");
            int x10 = 1, y9 = 3, z6 = 4;
            bool wynik5 = (x == 1 | y9++ > 2 || ++z6 > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik5, x10, y9, z6);

            Console.WriteLine("Zadanie 2.9 f) TRUE = x=1, y=4,z=5");
            int x11 = 1, y10 = 3, z7 = 4;
            bool wynik6 = (x11 == 1 | y10++ > 2 | ++z7 > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik6, x11, y10, z7);

            /*
             * Zadanie 2.10
             */
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / (double)powierzchnia;
            Console.WriteLine(gestoscZaludnienia);

            Console.ReadKey();
        }
    }
}