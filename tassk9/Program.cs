using System;

namespace tassk9
{
    class Program
    {
        public static int Enter()
        {
            int el = 0;
            bool ok = true;
            do
            {
                try
                {
                    el = Int32.Parse(Console.ReadLine());
                    ok = true;
                    if (el < 1)
                    {
                        Console.WriteLine("Ошибка, количество элементов должно быть больше 0");
                        ok = false;
                    }
                }
                catch
                {
                    ok = false;
                    Console.WriteLine("Ошибка, введите целое число");
                }
            } while (!ok);
            return el;
        }
        public static int Enter1()
        {
            int el = 0;
            bool ok = true;
            do
            {
                try
                {
                    el = Int32.Parse(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    ok = false;
                    Console.WriteLine("Ошибка, введите целое число");
                }
            } while (!ok);
            return el;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов списка:");
            int N=Enter();
            BiList b = new BiList();
            b.Create(N, 1);
            b.Show();
            Console.WriteLine("Введите значение искомого элемента:");
            int search = Enter1();
            b.Research(search, 0);
            int count = b.Count;
            Console.WriteLine("Введите значение элемента, который нужно удалить:");
            int del = Enter1();
            b.Delete(del);
            if (count == b.Count) Console.WriteLine("Такого элемента нет в списке");
            b.Show();
            Console.ReadKey();
        }
    }
}
