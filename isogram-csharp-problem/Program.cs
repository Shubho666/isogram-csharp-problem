using System;

namespace isogram_csharp_problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }

        public static bool IsogramCheck(string x)
        {
            //return a + b;
            //return false;

            if (x == "") return true;

            int[] place = new int[200];
            for(int i=0;i<x.Length;i+=1)
            {
                place[(int)(x[i])] += 1;
            }
            bool flag = true;
            for (int i = 65; i <= 90; i += 1)
            {
                if (place[i] > 1)
                {
                    flag = false; break;
                }
            }
            for (int i = 97; i <= 122; i += 1)
            {
                if (place[i] > 1)
                {
                    flag = false; break;
                }
            }
            return flag;

        }


    }
}
