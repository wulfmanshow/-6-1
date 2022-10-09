using System;

namespace Лаба_6_вариант_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] botans = new Student[10];
            Human[] prettyGirls = new PrettyGirl[10];
            for(int i = 0; i < 10; i++)
            {
                botans[i] = new Student();
                
            }
            for (int i = 0; i < 10; i++)
            {
                prettyGirls[i] = new PrettyGirl();

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
            Human.Couple(botans[i], prettyGirls[j]);
                }

            }
        }


    }
}
