using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsScribble
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12, reverse = 0;
            string idea = "idea";
            var num = number.ToString();
            char[] ideas = num.ToCharArray();

            //var total = Convert.ToInt32(idea[0]);// + Convert.ToInt32(idea[1]);

            foreach (var item in ideas)
            {
                var total1 = Convert.ToInt32(ideas[0]);
                var total2 = Convert.ToInt32(ideas[1]);

                var total = total1 + total2;
                //Console.WriteLine(ideas[0] + " "+ideas[1]);
                Console.WriteLine(total);
            }
            //Console.WriteLine(total);

            //List<int> array = new List<int>();

            //for (int i = 0; i < number-1; i++)
            //{
            //    array.Add(i);
            //}

            //foreach (var item in array)
            //{

            //}

            //bool answer;
            //if (pin.Count <= 6)
            //{
            //    answer = true;

            //    if (pin.Count < 5)
            //    {
            //        answer = true;
            //    }
            //    return answer;
            //}
            //return false;

            //Console.WriteLine(array);

            //while(number > 0)
            //{
            //    var remainder = number % 10;
            //    reverse = reverse * 10 + remainder;
            //    number = number / 10;
            //}

            //Console.WriteLine(reverse);

            //int n, reverse = 0, rem;
            //Console.Write("Enter a number: ");
            //n = int.Parse(Console.ReadLine());
            //while (n != 0)
            //{
            //    rem = n % 10;
            //    reverse = reverse * 10 + rem;
            //    n /= 10;
            //}
            //Console.Write("Reversed Number: " + reverse);

            Console.ReadLine();
        }
    }
}
