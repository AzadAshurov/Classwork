namespace AzadDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            string[] katalog = { "Azad", "Murad", "Nicat" };
            do
            {
                Console.WriteLine("1 for addding contact");
                Console.WriteLine("2 for showing contact");
                Console.WriteLine("3 for searching contact");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        string name = Console.ReadLine();
                        Array.Resize(ref katalog, katalog.Length + 1);
                        katalog[katalog.Length - 1] = name;
                        break;
                    case "2":
                        for (int i = 0; i < katalog.Length; i++)
                        {
                            Console.WriteLine(katalog[i]);
                        }
                        break;
                    case "3":
                        bool present = false;
                        string findName = Console.ReadLine();
                        for (int i = 0; i < katalog.Length; i++)
                        {
                            if (findName == katalog[i])
                            {
                                present = true;
                                break;
                            }
                        }
                        if (present)
                        {
                            Console.WriteLine("Yes, name " + findName + " is present in our contacts");
                        }
                        else
                        {
                            Console.WriteLine("Name " + findName + " absents in our contacts");
                        }
                        break;
                }
            }
            while (option == "1" || option == "2" || option == "3");












        }
    }
}