using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        
      public interface ISeries
        {
            int GetNext();//возвращает следующее число ряда увеличенное на 2
            int reset();//выполняет перезапуск
            int setStart(int x);//устанавливает начальное значение
        }
        class ByTos : ISeries
        {
            int start;
            int val;

            public ByTos()
            {
                start = 0;
                val = 0;
            }

            public int GetNext()
            {
                val += 2;
                return val;
            }
            public int reset()
            {
                val = start;
            }

            public int setStart(int x)
            {
                start = x;
                val = start;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                ByTos ob = new ByTos();
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее значение равно " + ob.GetNext());

                Console.WriteLine("\nПереход в исходное состояние.");
                ob.reset();
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее значение равно " + ob.GetNext());

                Console.WriteLine("\nНачинаем с числа 100.");
                ob.setStart(100);
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее значение равно " + ob.GetNext());
                Console.ReadLine();
            }
        }
    }
}

    

