using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Vyvedete mesec za koyto iskate da izprintim datite: ");
        string mesec = Console.ReadLine();

        switch(mesec)
        {
            case "januar":
                datumMesec(1);
                break;
            case "februar":
                datumMesec(2);
                break;
            case "mart":
                datumMesec(3);
                break;
            case "april":
                datumMesec(4);
                break;
            case "maj":
                datumMesec(5);
                break;
            case "jun":
                datumMesec(6);
                break;
            case "jul":
                datumMesec(7);
                break;
            case "avgust":
                datumMesec(8);
                break;
            case "septembar":
                datumMesec(9);
                break;
            case "oktobar":
                datumMesec(10);
                break;
            case "novembar":
                datumMesec(11);
                break;
            case "decembar":
                datumMesec(12);
                break;
            default: 
                Console.WriteLine("nati kur");
                break;
        }
    }

    private static void datumMesec(int mesec)
    {
            int n = 31;
            if (mesec % 2 == 0 && mesec < 8)
            {
                n = 30;
            }
            else if(mesec % 2 == 1 && mesec > 8)
            {
                n = 30;
            }
            if (mesec == 2)
            {
                n = 28;
            }
            for (int i = 1; i <= n; i++)
            {
                if (i < 10 && mesec < 10)
                {
                    Console.WriteLine("0" + i + ".0" + mesec);
                }
                else if (i < 10 && mesec > 9)
                {
                    Console.WriteLine("0" + i + "." + mesec);
                }
                else if(i > 9 && mesec < 10)
                {
                    Console.WriteLine(i + ".0" + mesec);
                }
                else
                {
                    Console.WriteLine(i + "." + mesec);
                }
            }
    }
}