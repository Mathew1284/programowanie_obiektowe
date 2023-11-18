using System;
namespace Cwiczenie
{
    class program
    {
        static void Main(string[] args)
        {
            double choose;
            Console.WriteLine("Proszę wybrać zadanie (zadanie 4.1 -> 4.01) :");
            choose = Convert.ToDouble(Console.ReadLine());
            switch (choose)
            {
                case 4.01:
                    int n;
                    Console.WriteLine("Proszę podać rozmiar tablicy:");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] tablica1 = new int[n];
                    for (int i = 0; i < tablica1.Length; i++)
                    {
                        Console.WriteLine("Proszę podać liczbę:");
                        tablica1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    foreach (int item in tablica1)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();

                    break;
                case 4.2:
                    int[] tab1 = new int[10];
                    int[] tab2 = new int[10];
                    for (int i = 0; i < tab1.Length; i++)
                    {
                        Console.WriteLine("Proszę podać liczbe:");
                        tab1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int i = 0; i < tab1.Length; i++)
                    {
                        if (tab1[i] > 0)
                        {
                            tab2[i] = tab1[i];
                        }
                    }
                    foreach (int item in tab2)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                    break;
                case 4.3:
                    int nn;
                    Console.WriteLine("Proszę podać rozmiar tablicy:");
                    nn = Convert.ToInt32(Console.ReadLine());
                    int[] tab_1 = new int[nn];
                    Console.WriteLine();
                    for(int i = 0; i < tab_1.Length; i++)
                    {
                        Console.WriteLine("Proszę podać liczbę:");
                        tab_1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int min = tab_1[0], max = tab_1[0], liczby_dodatnie = 0;
                    double x=0, srednia=0;
                    for(int i = 0; i < tab_1.Length; i++)
                    {
                        x += tab_1[i];
                        if (tab_1[i] < min)
                        {
                            min = tab_1[i];
                        }
                        else if (tab_1[i] > max)
                        {
                            max = tab_1[i];
                        }
                    }
                    for (int i = 0; i < tab_1.Length; i++)
                    {
                        
                        if (tab_1[i] > 0)
                        {
                            liczby_dodatnie += tab_1[i];
                        }
                    }
                    srednia = x / tab_1.Length;
                    Console.WriteLine("Max element:{0,1}  min element:{1,1}  ", max, min);
                    Console.WriteLine("średnia:{0,1}  wartosc liczb dodatnich:{1,1} ", srednia, liczby_dodatnie);
                    break;
                case 4.4:
                    Random rand = new Random();
                    int suma1 = 0;
                    int[] tablica2 = new int[100];
                    for (int i = 0; i < tablica2.Length; i++)
                    {
                        tablica2[i] = rand.Next(1,1000);
                    }
                    foreach(int item in tablica2)
                    {
                        int xx = (int)Math.Floor(Math.Sqrt(item));
                        for (int i = 2; i <= xx; i++)
                        {
                            if (item % i == 0)
                            {

                            }
                            else if(i == xx)
                            {
                                suma1++;
                            }
                        }
                    }
                    Console.WriteLine("Ilosc liczb pierwszych wynosi:{0}", suma1);
                    break;
                case 4.5:
                    int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    int[] array2 = new int[array1.Length];
                    Array.Copy(array1, 0, array2, 1, 8);
                    Array.Copy(array1, 8, array2, 0, 1);
                    foreach(int item in array2)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();

                    break;
                case 4.6:
                    int[,] array3 =
                    {
                        {1,2,3,4,5 },
                        {1,2,3,4,5 },
                        {1,2,3,4,5 },
                        {1,2,3,4,5 },
                        {1,2,3,4,5 }
                    };
                    for (int i = 0; i < array3.GetLength(0); i++)
                    {
                        for (int j = 0; j < array3.GetLength(1); j++)
                        {
                            Console.Write(array3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    int suma_przekatnej = 0;
                    for (int i = 0; i < array3.GetLength(0); i++)
                    {
                        suma_przekatnej += array3[i, i];
                    }
                    Console.WriteLine("suma elementow przekątnej wynosi:{0}", suma_przekatnej);

                    break;
                case 4.7:
                    int[,] matrix1 =
                    {
                        {1,2,3 },
                        {1,2,3 }
                    };
                    int[,] matrix2 =
                    {
                        {1,2,3 },
                        {1,2,3 }
                    };
                    int[,] matrix3 = new int[2, 3];
                    for (int i = 0; i < matrix3.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix3.GetLength(1); j++)
                        {
                            matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                            Console.Write(matrix3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4.8:
                    string[,] dniTygodnia;
                    dniTygodnia = new string[7, 3]; 
                    dniTygodnia[0, 0] = "poniedzialek";
                    dniTygodnia[1, 0] = "wtorek";
                    dniTygodnia[0, 1] = "monday";
                    dniTygodnia[1, 1] = "tuesday";
                    dniTygodnia[0, 2] = "montag";
                    dniTygodnia[1, 2] = "dienstag";
                    dniTygodnia[2, 0] = "środa";
                    dniTygodnia[2, 1] = "Wednesday";
                    dniTygodnia[2, 2] = "Mittwoch";
                    dniTygodnia[3, 0] = "Czwartek";
                    dniTygodnia[3, 1] = "Thursday";
                    dniTygodnia[3, 2] = "Donnerstag";
                    dniTygodnia[4, 0] = "Piątek";
                    dniTygodnia[4, 1] = "Friday";
                    dniTygodnia[4, 2] = "Freitag";
                    dniTygodnia[5, 0] = "sobota";
                    dniTygodnia[5, 1] = "Saturday";
                    dniTygodnia[5, 2] = "Samstag";
                    dniTygodnia[6, 0] = "niedziela";
                    dniTygodnia[6, 1] = "Sunday";
                    dniTygodnia[6, 2] = "Sonntag";
                    for (int i = 0; i < dniTygodnia.GetLength(0); i++)
                    {
                        for (int j = 0; j < dniTygodnia.GetLength(1); j++)
                        {
                            Console.Write(dniTygodnia[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    break;
                case 4.9:
                    int suma3 = 0;
                    Console.WriteLine("Prosze podać zdanie kończące kropką:");
                    string zdanie = Console.ReadLine();
                    foreach(char item in zdanie)
                    {
                        if(item == ' ')
                        {
                            suma3 += 1;
                        }
                        else if(item == '.')
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Ilosc wyrazor w tekscie jest:{0}", suma3+1);
                    break;
                case 4.10:
                    Console.WriteLine("Prosze wpisać DD-MM-RRRR");
                    string dane = Console.ReadLine();
                    string miesiac = dane.Substring(3, 2);
                    if(miesiac == "01")
                    {
                        Console.WriteLine("Styczeń");
                    }
                    else if(miesiac == "02")
                    {
                        Console.WriteLine("Luty");
                    }
                    else if (miesiac == "03")
                    {
                        Console.WriteLine("Marzec");
                    }
                    else if (miesiac == "04")
                    {
                        Console.WriteLine("Kwiecień");
                    }
                    else if (miesiac == "05")
                    {
                        Console.WriteLine("Maj");
                    }
                    else if (miesiac == "06")
                    {
                        Console.WriteLine("Czerwiec");
                    }
                    else if (miesiac == "07")
                    {
                        Console.WriteLine("Lipiec");
                    }
                    else if (miesiac == "08")
                    {
                        Console.WriteLine("Sierpień");
                    }
                    else if (miesiac == "09")
                    {
                        Console.WriteLine("Wrzesień");
                    }
                    else if (miesiac == "10")
                    {
                        Console.WriteLine("Październik");
                    }
                    else if (miesiac == "11")
                    {
                        Console.WriteLine("Listopad");
                    }
                    else if (miesiac == "12")
                    {
                        Console.WriteLine("Grudzień");
                    }
                    else
                    {
                        Console.WriteLine("Podano niewłaściwy miesiac");
                    }
                    break;
                case 4.11:
                    string zdanie2 = "abrakadabra";
                    int a = 0, b = 0, r = 0, k = 0, d = 0;
                    foreach(char item in zdanie2)
                    {
                        if(item == 'a')
                        {
                            a++;
                        }
                        else if(item == 'b')
                        {
                            b++;
                        }
                        else if(item == 'r')
                        {
                            r++;
                        }
                        else if(item == 'k')
                        {
                            k++;
                        }
                        else if(item == 'd')
                        {
                            d++;
                        }
                    }
                    Console.WriteLine("a = {0,1}  b={1,1}  r={2,1}  k={3,1}  d={4,1}", a, b, r, k, d);
                    break;
                case 4.12:
                    string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                                 "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                                 "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                                 "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                                 "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
                    Console.WriteLine(tekst);
                    int ilosc_wierszy = 1, ilosc_znakow = 0;
                    for (int i = 0; i < tekst.Length; i++)
                    {
                        if (tekst[i] == '\n')
                        {
                            ilosc_znakow = 0;
                            ilosc_wierszy++;
                        }
                        else
                        {
                            ilosc_znakow++;
                        }
                    }
                    Console.WriteLine("Ilosc wierszy w tekscie:{0,1}  ilosc znakow w tekscie{1,1}", ilosc_wierszy, ilosc_znakow);
                    break;
                case 4.13:
                    

                    break;
                case 4.14:
                    string[] y = { "DI-2001", "SQW-2000", "AI-2004", "KOMG-2002", "BH-2010" };
                    Console.WriteLine(y[0]);
                    int data = DateTime.Today.Year;
                    int indeks;
                    int temp;
                    for (int item = 0; item < y.GetLength(0); item++)
                    {
                        indeks = y[item].IndexOf('-');
                        temp = int.Parse(y[item].Substring(indeks + 1));
                        Console.WriteLine("Srodek trwaly wynosi:{0,1} zakupiony zostal:{1,1} lat temu.", y[item], data - temp);
                    }


                    break;
            }

            Console.ReadKey();
        }
    }
}