namespace AzadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int fract = 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    fract *= i;
            //}
            //Console.WriteLine(fract);




            //Console.WriteLine("Enter number");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //int numOne = 0;
            //int numTwo = 1;
            //while (numOne < maxNum && numTwo < maxNum)
            //{
            //    Console.WriteLine(numOne);
            //    Console.WriteLine(numTwo);
            //    numOne += numTwo;
            //    numTwo += numOne;


            //}


            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int numClone = num;
            //int sum = 0;
            //while (num != 0)
            //{
            //    num /= 10;
            //    count++;
            //}
            //for(int i = count; i > 0 ; i--)
            //{
            //    num = numClone;

            //    sum += num / (Math.Pow(10, (i - 1)));

            //}




            Console.WriteLine("Enter number");
            float maxNum = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            float count = 0;
            for (float i = 1; i <= maxNum; i++)
            {
                if (i % 15 == 0)
                {
                    count++;
                    sum += i;
                }

            }
            float mid = sum / count;
            Console.WriteLine("Mid equal to " + mid);



        }
    }
}