
using System;
    class Program
{
    static void Main()
    {
        Console.WriteLine(" Conversii intre baze:");
        Console.WriteLine("1.Binara <-> Octala ");
        Console.WriteLine("2.Binara <-> Zecimala ");
        Console.WriteLine("3.Binara <-> Hexazecimala ");
        Console.WriteLine("4.Octala <-> Zecimala ");
        Console.WriteLine("5.Octala <-> Hexazecimala ");
        Console.WriteLine("6.Zecimala <-> Hexazecimala ");
        Console.WriteLine("Alege o optiune (1-6): ");

        int optiune = int.Parse(Console.ReadLine());

        switch (optiune)
        {

            case 1:
                Console.WriteLine("Introdu un numar binar:");
                string binar = Console.ReadLine();

                //completam in fata zerourile pentru a forma grupuri de  3 
                while ( binar.Length%3!= 0)
                    binar = "0" + binar;

                string octal = " ";
                for (int i = 0; i < binar.Length; i+=3)
                {
                    int grup = (binar[i] - '0') * 4 + (binar[i + 1] - '0') * 2 + (binar[i + 2] - '0');
                    octal += grup.ToString();
                }

                Console.WriteLine($"Octal: {octal}");
                break;


            case 2: 
                Console.Write("Introdu un număr binar: ");
                binar = Console.ReadLine();


                int zecimal = 0, putere = 1;
                for (int i = binar.Length - 1; i >= 0; i--)
                {
                    if (binar[i] == '1')
                        zecimal += putere;
                    putere *= 2;
                }

                Console.WriteLine($"Zecimal: {zecimal}");

                Console.Write("Introdu un număr zecimal: ");
                zecimal = int.Parse(Console.ReadLine());

                binar = "";
                while (zecimal > 0)
                {
                    binar = (zecimal % 2) + binar;
                    zecimal /= 2;
                }

                Console.WriteLine($"Binar: {binar}");
                break;


            case 3: 
                Console.Write("Introdu un număr binar: ");
                binar = Console.ReadLine();

                // Completam cu zeorui pentru a forma grupuri de 4 
                while (binar.Length % 4 != 0)
                    binar = "0" + binar;

                string hex = "";
                char[] hexChars = "0123456789ABCDEF".ToCharArray();

                for (int i = 0; i < binar.Length; i += 4)
                {
                    int grup = (binar[i] - '0') * 8 + (binar[i + 1] - '0') * 4 + (binar[i + 2] - '0') * 2 + (binar[i + 3] - '0');
                    hex += hexChars[grup];
                }

                Console.WriteLine($"Hexazecimal: {hex}");
                break;


            case 4: 
                Console.Write("Introdu un număr octal: ");
                octal = Console.ReadLine();

                zecimal = 0;
                putere = 1;
                for (int i = octal.Length - 1; i >= 0; i--)
                {
                    zecimal += (octal[i] - '0') * putere;
                    putere *= 8;
                }

                Console.WriteLine($"Zecimal: {zecimal}");

                Console.Write("Introdu un număr zecimal: ");
                zecimal = int.Parse(Console.ReadLine());

                octal = "";
                while (zecimal > 0)
                {
                    octal = (zecimal % 8) + octal;
                    zecimal /= 8;
                }

                Console.WriteLine($"Octal: {octal}");
                break;



            case 5: 
                Console.Write("Introdu un număr octal: ");
                octal = Console.ReadLine();

                // Conversie octal → zecimal
                zecimal = 0;
                putere = 1;
                for (int i = octal.Length - 1; i >= 0; i--)
                {
                    zecimal += (octal[i] - '0') * putere;
                    putere *= 8;
                }

                // Conversie zecimal -> hexazecimal
                hex = "";
                hexChars = "0123456789ABCDEF".ToCharArray();
                while (zecimal > 0)
                {
                    hex = hexChars[zecimal % 16] + hex;
                    zecimal /= 16;
                }

                Console.WriteLine($"Hexazecimal: {hex}");
                break;



            case 6: // Zecimala -> Hexazecimala
                Console.Write(" Introdu un număr zecimal: ");
                zecimal = int.Parse(Console.ReadLine());

                hex = "";
                hexChars = "0123456789ABCDEF".ToCharArray();
                while (zecimal > 0)
                {
                    hex = hexChars[zecimal % 16] + hex;
                    zecimal /= 16;
                }

                Console.WriteLine(  $"  Hexazecimal: {hex}");

                Console.Write(  "Introdu un număr hexazecimal: ");
                hex = Console.ReadLine();

                zecimal = 0;
                putere = 1;
                for (int i =   hex.Length - 1; i >= 0; i--)
                {
                    int valoare  =    hex[i] >= 'A' ? hex[i] - 'A' + 10 : hex[i] - '0';
                    zecimal +=   valoare * putere;
                    putere *= 16;
                }

                Console.WriteLine($"Zecimal: {zecimal}");
                break;

            default:
                Console.WriteLine("Opțiune invalidă.");
                break;




        }
        Console.ReadKey();
    }
}
