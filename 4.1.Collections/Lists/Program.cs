namespace Program
{
    class Lists
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>(); // Dynamic, resizable, must specify the type of data
                                                      // T is a list that can adapt the datatype for the elements received
                                                      // Database Records, Database Manipulation
                                                      // Capacity Management, use foreach loops

            myList.Add("blue");  // Adds item on the last intex
            myList.Add("red");
            myList.Add("red");
            myList.Add("blue");
            myList.Remove("blue"); // Removes the first ocurrence of element blue
            foreach (string n in myList)
            {
                System.Console.WriteLine(n);
            }

            while (myList.Remove("blue"))
            {
                myList.Remove("blue");      // Code for removing all the ocurrences of blue
            }
            System.Console.WriteLine("ok");
            foreach (string n in myList)
            {
                System.Console.WriteLine(n);
            }

            // CLASS 2
            // INITIALIZING LIST WITH ITEMS
            List<string> colors = ["red", "blue", "green"];

            // CLASS 3
            // SORTING
            System.Console.WriteLine("\nSorting");
            List<int> numbers = [1, 2, 13, 4, 8];
            numbers.Sort();
            foreach (int n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // CLASS 4
            // FINDALL
            System.Console.WriteLine("\nFindAll");
            List<int> numbersFindAll = [1, 2, 13, 10, 4, 8, 25, 50, 124, 54];
            List<int> findAll_list = numbersFindAll.FindAll(x => x == 10); // PREDICATES
            foreach (int n in findAll_list)
            {
                System.Console.WriteLine(n);
            }

            // CLASS 5
            // PREDICATES AND LAMBAS

            // LAMBDA FUNCTIONS CONSISTS OF 2 PARTS
            // 1. PARAMETERS, 2. EXPRESSION (STATEMENT BLOCK)

            // PARAMETERS ARE WRITTEN ON THE LEFT SIDE OF =>
            // => == "GOES TO" OR "BECOMES"
            // THE EXPRESSION IS ON THE RIGHT SIDE OF =>
            System.Console.WriteLine("\nLAMBDA");
            int x = 3;
            Predicate<int> y = x => x >= 10;
            List<int> findAll_list2 = numbersFindAll.FindAll(y); // PREDICATES
            foreach (int n in findAll_list2)
            {
                System.Console.WriteLine(n);
            }

        }
        
    }
}