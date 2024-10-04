namespace Azad3
{
    internal class Program
    {
        static void Main(string[] args)
        {





            int[] numbers = { 345, 6, 4345, 2, 654, 7, 8, 433 };
            string[] words = { "Salam", "Azad", "Sen", "Necesen", "Mene", "Pul", "Ver" };
            Console.WriteLine("Enter 1 for getting max number");
            Console.WriteLine("Enter 2 for reverse array");
            Console.WriteLine("Enter 3 for reverse array and it's letters");
            string option;

            do
            {
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        int numMax = numbers[0];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] > numMax)
                            {
                                numMax = numbers[i];
                            }
                        }
                        Console.WriteLine(numMax);
                        break;
                    case "2":
                        string[] revestWords = { };
                        Array.Resize(ref revestWords, words.Length);
                        for (int i = words.Length - 1; i >= 0; i--)
                        {
                            revestWords[words.Length - i - 1] = words[i];
                        }
                        for (int j = 0; j < words.Length; j++)
                        {
                            Console.WriteLine(revestWords[j]);
                        }
                        break;
                    case "3":
                        string[] revestWordsLet = { };
                        Array.Resize(ref revestWordsLet, words.Length);
                        for (int i = words.Length - 1; i >= 0; i--)
                        {
                            revestWordsLet[words.Length - i - 1] = words[i];
                        }
                        for (int j = 0; j < words.Length; j++)
                        {
                            string revestLetter = "";
                            for (int k = revestWordsLet[j].Length - 1; k >= 0; k--)
                            {
                                revestLetter += revestWordsLet[j][k];
                            }
                            Console.WriteLine(revestLetter);
                        }


                        break;

                }

            }
            while (option == "1" || option == "2" || option == "3");














        }
    }
}