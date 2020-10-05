using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleUnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] { 00, 01, 02, 04, 05, 06, 11, 12, 13, 14, 15, 16, 22, 23, 24, 25, 26, 33, 34, 35, 36, 44, 45, 46, 55, 56, 66 };
            int[] b = new int[] { 2,4, 6 };
            bool flag1 = false; bool flag2 = false;

            Console.WriteLine("Входные данные:\n{0}", string.Join("\n", b));
            Console.WriteLine("\nПравая сторона:");
            foreach (int i in a)
            {
                foreach (int g in b)
                    if (i % 10 == g) //первое условие
                    {
                        flag1 = true;
                        Console.WriteLine(i);
                    }
                    }

            Console.WriteLine("\nОбе стороны:");
            foreach (int i in a)
            {
                foreach (int g in b)
                    if ((int)((int)i / Math.Pow(10, (int)Math.Log10(i))) == g && i % 10 == g) //второе условие
                    {
                        flag2 = true;
                        Console.WriteLine(i);
                    }
                    }
            Console.ReadLine();

            //Console.Write("введите число: ");
            //int value = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i < value; i++)
            //    if (value % i == 0) sum += i;
            //if (value == sum) Console.WriteLine("Число совершенное");
            //else Console.WriteLine("Число не совершенное");
            //Console.ReadLine();
        }
        
        public double Task_1(double x, double y)
        {
            return x + y;
        }

        public double Task_2(double x, double y)
        {
            return x + y;
        }

        public bool Task_3(int x, int y)
        {
            return ((x + y) % 2) == 0;
        }

        public bool Task_4(int x, int y, int j)
        {
            return ((x + y) % j) == 0;
        }

        public bool Task_5(double x, double y)
        {
            return (x > y);
        }

        public bool Task_6(double x, double y, double j)
        {
            return (x + y) < j;
        }

        public bool Task_7(double x, double y)
        {
            return x > y == true;
        }

        public bool Task_8(int x, int y, int j, int z)
        {
            int[] intNumbers = new int[] { x, y, j };
            int MSLowestNumber = intNumbers.Min();
            return MSLowestNumber == z;
        }

        public bool Task_9(int x, int y, int j)
        {
            return (x * y * j) < 1000;
        }

        public bool Task_10(int x, int y, int j, int s)
        {
            return (x * y * j) > s;
        }

        public bool Task_11(int x, int y, int j)
        {
            int[] scores = new int[] { x, y, j };
            int sum = 0; int sum2 = 0;

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 20
                select score;

            foreach (int i in scoreQuery)
            {
                sum += i;
            }

            IEnumerable<int> scoreQuery2 =
                           from score in scores
                           where score < 50
                           select score;

            foreach (int i in scoreQuery2)
            {
                sum2 += i;
            }

            return sum > 100 && (sum2 % 2) == 0;
        }

        public bool Task_12(int x, int y, int j)
        {
            int[] scores = new int[] { x, y, j };
            int sum = 0; int sum2 = 0;

            IEnumerable<int> scoreQuery =
                from score in scores
                where score < 50
                select score;

            foreach (int i in scoreQuery)
            {
                sum += i;
            }

            IEnumerable<int> scoreQuery2 =
                           from score in scores
                           where score <= 10
                           select score;

            foreach (int i in scoreQuery2)
            {
                sum2 += i;
            }

            return sum < 50 && sum2 % 3 == 0;
        }

        public bool Task_13(double x, double y, double p)
        {
            double[] scores = new double[] { x, y };
            double sum = 0;

            IEnumerable<double> scoreQuery =
                from score in scores
                where score > 20.5
                select score;

            foreach (double i in scoreQuery)
            {
                sum += i;
            }

            return sum < p;
        }

        public bool Task_14(int x, int y, int m, int q)
        {
            int[] scores = new int[] { x, y };
            int sum = 0;

            IEnumerable<int> scoreQuery =
                from score in scores
                where score <= m
                select score;

            foreach (int i in scoreQuery)
            {
                sum += i;
            }

            return sum > q;
        }

        public bool Task_15(int x, int y, int m, int p)
        {
            int[] scores = new int[] { x, y };
            int sum = 0;

           
            IEnumerable<int> scoreQuery =
                from score in scores
                where score <= m
                select score;

            foreach (int i in scoreQuery)
            {
                sum += i;
            }
            return sum % p == 0;
        }

        public bool Task_16(int x, int y, int m, int p)
        {

            int[] scores = new int[] { x, y, m, p }; //количество осадков в дни
            int sum = 0; int sum2 = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (i % 2 != 0) sum += scores[i];//четное
                if (i % 2 == 0) sum2 += scores[i];//нечетное
            }
            return sum > sum2;
        }

        public bool Task_17(int x, int y, int m, int p)
        {

            int[] scores = new int[] { x, y, m, p }; 
            int sum = 0; int sum2 = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (i % 2 != 0) sum += scores[i];//четное
                if (i % 2 == 0) sum2 += scores[i];//нечетное
            }
            return sum < sum2;
        }

        public bool Task_18(int x, int y, int m, int p, int l)
        {

            int[] scores = new int[] { x, y, m, p, l }; //количество осадков в дни
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 0) g++;//четное
            }
            Console.WriteLine(g);
            return g < 5;
        }

        public bool Task_19(int x, int y, int m, int p)
        {

            int[] scores = new int[] { x, y, m, p }; //количество осадков в дни
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 55.5) g++;//четное
            }
            Console.WriteLine(g);
            return g % 4 == 0;
        }

        public bool Task_20(int x, int y, int m, int p)
        {
            int[] scores = new int[] { x, y, m, p }; //количество осадков в дни
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 20) g++;//четное
            }
            Console.WriteLine(g);
            return g == 5;
        }

        public bool Task_21(int x, int y, int m, int p, int l)
        {
            int[] scores = new int[] { x, y, m, p, l }; //количество осадков в дни
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 0) g++;//четное
            }
            Console.WriteLine(g);
            return g == 5;
        }

        public bool Task_22(int x, int y, int m, int p)
        {
            int[] scores = new int[] { x, y, m };
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 0) g++;
            }
            return g > p;
        }

        public bool Task_23(int x, int y, int m, int p)
        {
            int[] scores = new int[] { x, y };
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > m) g++;
            }
            return g % p == 0;
        }

        public bool Task_24(int x, int y, int m, int p)
        {
            int[] scores = new int[] { x, y, m, p };
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 3) g++;
            }
            return g == 0;
        }

        public bool Task_25(int x, int y, int m, int p)
        {
            int[] scores = new int[] { x, y, m, p };
            int g = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 0) g++;
            }
            return g == 2;
        }

        public bool Task_26(int x, int y, int m, int p)
        {
            int[] auto = new int[] { x, y };
            int[] bike = new int[] { m, p };
            int avgBike = 0; int avgAuto = 0;

            for (int i = 0; i < auto.Length; i++)
            {
                avgAuto += auto[i] / auto.Length;
                avgBike += bike[i] / bike.Length;
            }
            return (avgAuto / avgBike) == 3;
        }

        public bool Task_27(int x, int y, int m, int p)
        {
            int[] height = new int[] { x, y, m, p };
            int sumboy = 0; int sumgirl = 0;
            int countboy = 0; int countgirl = 0;

            foreach (var i in height)
            {
                if (i < 0) sumboy -= +i; countboy++;
                if (i > 0) sumgirl += +i; countgirl++;
            }

            double avgBoys = sumboy / countboy;
            double avgGirls = sumgirl / countgirl;
            return (avgBoys - avgGirls) > 10;
        }

        public bool Task_28(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m, p };
            int sumNumb = 0; int bigNumb = 0;

            foreach (var i in numb)
            {
                if (i > 10) { sumNumb += i; bigNumb++; }
            }

            if (bigNumb > 0)
            { double avgNumb = sumNumb / bigNumb; }
            else
                Console.WriteLine("Делить на ноль нельзя");
            return bigNumb > 1;
        }

        public bool Task_29(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m };
            int sumNumb = 0; int bigNumb = 0;

            foreach (var i in numb)
            {
                if (i > p) { sumNumb += i; bigNumb++; }
            }

            if (bigNumb > 0)
            { double avgNumb = sumNumb / bigNumb; }
            else
                Console.WriteLine("Делить на ноль нельзя");
            return bigNumb > 1;
        }

        public bool Task_30(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m, p };
            int sumNumb = 0; int bigNumb = 0;

            foreach (var i in numb)
            {
                if (i % 2 == 0) { sumNumb += i; bigNumb++; }
            }

            if (bigNumb > 0)
            { double avgNumb = sumNumb / bigNumb; }
            else
                Console.WriteLine("Делить на ноль нельзя");
            return bigNumb > 1;
        }

        public bool Task_31(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m };
            int sumNumb = 0; int bigNumb = 0;

            foreach (var i in numb)
            {
                if (i % p == 0) { sumNumb += i; bigNumb++; }
            }

            if (bigNumb > 0)
            { double avgNumb = sumNumb / bigNumb; }
            else
                Console.WriteLine("Делить на ноль нельзя");
            return bigNumb > 1;
        }

        public bool Task_32(int x, int y, int m, int p)
        {
            List<int> numb = new List<int> { x, y, m, p };
            int index = numb.LastIndexOf(100);
            if (index < 0)
            { Console.WriteLine("Нет чисел, равных 100"); }
            else
                Console.WriteLine(index);
            return index > 1;
        }

        public bool Task_33(int x, int y, int m, int p)
        {
            int[] numb2 = new int[] { x, y, m, p };
            int index = Array.FindLastIndex(numb2, n => n < 0);
            if (index < 0)
            { Console.WriteLine("Нет отрицательных числе"); }
            else
                Console.WriteLine(index);
            return index > 1;
        }

        public bool Task_34(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m, p };
            int max = numb.Max();
            int min = numb.Min();
            var res = max - min;
            Console.WriteLine("Разница: " + res); 
            if (res < 25)
            {
                Console.WriteLine("Максимальное число превышет минимальное не более чем на 25");
            }
            else
                Console.WriteLine("Максимальное число превышет минимальное более чем на 25");
            return res < 25;
        }

        public bool Task_35(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m, p };
            int max = numb.Max();
            int min = numb.Min();
            var res = max / min;
            Console.WriteLine("Разница: " + res);
            if (res > 2)
            {
                Console.WriteLine("Максимальное число превышает минимальное более чем в 2 раза");
            }

            else if (res == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }

            else
                Console.WriteLine("Максимальное число превышает минимальное менее чем в 2 раза");

            return res > 2;
        }

        public bool Task_36(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m, p };
            int indexMax = Array.FindIndex(numb, n => n == numb.Max());
            int indexMin = Array.FindIndex(numb, n => n == numb.Min());
            if (indexMax < indexMin)
            { Console.WriteLine("Первым встречается максимальное число"); }
            else
                Console.WriteLine("Первым встречается минимальное число");
            return indexMax < indexMin;
        }

        public bool Task_37(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y, m, p };
            int indexMax = Array.FindIndex(numb, n => n == numb.Max());
            int indexMin = Array.FindIndex(numb, n => n == numb.Min());
            if (indexMax < indexMin)
            { Console.WriteLine("Первым встречается самый старый"); }
            else
                Console.WriteLine("Первым встречается самый молодой");
            return indexMax < indexMin;
        }

        public bool Task_38(double x, double y, double m, double p)
        {
            double [] numb = new double[] { x, y, m, p }; //результаты за каждый круг
            double indexMax = Array.FindIndex(numb, n => n == numb.Max());
            double indexMin = Array.FindIndex(numb, n => n == numb.Min());
            if (indexMin < indexMax)
            { Console.WriteLine("Выигрышный этап был первым"); }
            else
                Console.WriteLine("Выигрышный этап не был первым");
            return indexMin < indexMax;
        }

        public bool Task_39(int x, int y, int m, int p)
        {
            int[] numb = new int[] { x, y , m, p};
            var set = new HashSet<int>();
            int i = 0; int z = -1;
            foreach (var item in numb)
                if (!set.Add(item))
                {
                    i++;
                }
                else
                    z++;
            Console.WriteLine("Дубли:" + i + " Недубли: " + (z));
            return i > 0 && z > 0; //Если присутствуют дубли и не дубли, то условия выполняются
        }

        public bool Task_40(int x, int y, int m, int p)
        {

            List<int> numb = new List<int> { x, y, m, p };
            var total = numb.GroupBy(_ => _).Where(_ => _.Count() > 1).Sum(_ => _.Count());
            int res = numb.Count - total;
            Console.WriteLine("Кол-во неповторяющихся " + res);
            return res > 0; //Если присутствуют не дубли, то условия выполняются
        }

        public bool Task_41(int x, int y, int m, int p)
        {
            int[] a = new int[] { 00, 01, 02, 04, 05, 06, 11, 12, 13, 14, 15, 16, 22, 23, 24, 25, 26, 33, 34, 35, 36, 44, 45, 46, 55, 56, 66 };
            int[] b = new int[] { 2, 4, 6 };
            bool flag1 = false; bool flag2 = false;

            Console.WriteLine("Входные данные:\n{0}", string.Join("\n", b));
            Console.WriteLine("\nПравая сторона:");
            foreach (int i in a)
            {
                foreach (int g in b)
                    if (i % 10 == g) //первое условие
                    {
                        flag1 = true;
                        Console.WriteLine(i);
                    }
            }

            Console.WriteLine("\nОбе стороны:");
            foreach (int i in a)
            {
                foreach (int g in b)
                    if ((int)((int)i / Math.Pow(10, (int)Math.Log10(i))) == g && i % 10 == g) //второе условие
                    {
                        flag2 = true;
                        Console.WriteLine(i);
                    }
            }

            return flag1 == true && flag2 == true;
        }

        public bool Task_42(int N)
        {

            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        public bool Task_43(int value)
        {
            int sum = 0;
            for (int i = 1; i < value; i++)
                if (value % i == 0) sum += i;
            if (value == sum)
                return true;
            else Console.WriteLine("Число не совершенное");
            return false;
        }
    }
}
