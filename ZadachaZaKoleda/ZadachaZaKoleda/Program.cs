namespace ZadachaZaKoleda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            while (true)
            {
            int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        NumPrint();
                        break;
                    case 2:
                        SumOfNums();
                        break;
                    case 3:
                        EvenNums();
                        break;
                    case 4:
                        OddNums();
                        break;
                    default:
                        Console.WriteLine("Грешка! Моля, въведете валидно число от 1 до 4.");
                        break;
                }
                if (num >= 1 && num <=4)
                {
                    break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("                        Меню:");
            Console.WriteLine();
            Console.WriteLine("Натиснете 1 за извеждане на числата от 1 до 24.");
            Console.WriteLine("Натиснете 2 за извеждане на сумата на числата от 1 до 24.");
            Console.WriteLine("Натиснете 3 за извеждане на четните числа от 1 до 24.");
            Console.WriteLine("Натиснете 4 за извеждане на нечетните числа от 1 до 24.");
            Console.WriteLine();
            Console.Write("Въведете число от 1 до 4: ");
        }

        static void NumPrint()
        {
            for (int i = 1; i <= 23; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.Write("24");
        }

        static void SumOfNums()
        {
            int sum = 0;
            for(int i = 1;i <= 24; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Сумата е: " + sum);
        }

        static void EvenNums()
        {
            for (int i = 1; i <= 23; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
                Console.Write("24");
        }

        static void OddNums()
        {
            for (int i = 1; i <= 22; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}, ");
                }
            }
                Console.Write("23");
        }
    }
}
