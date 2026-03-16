namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var list = new List<string>() { "Hello", "World" }; // Initialize a List with a collection initializer
            List<string> list2 = [ "Hello", "Coding" ]; // Initialize a List with a collection initializer using the new C# 12.0 syntax


            var hashSet = new HashSet<string>() { "Hello", "Coding", "Factory" };        // Initialize a HashSet with a collection initializer
            HashSet<string> hashSet2 = [ "Hello", "Coding", "Factory" ];        // Initialize a HashSet with a collection initializer using the new C# 12.0 syntax


            var dict = new Dictionary<string, int>() 
            { 
                { "one", 1 },   // Initialize a Dictionary with a collection initializer
                { "two", 2 } 
            }; 

            var dict2 = new Dictionary<int, string>()
            { 
                [1] = "one",    // Initialize a Dictionary with a collection initializer using the new C# 12.0 syntax
                [2] = "2" 
            };     


            Stack<string> stack1 = new Stack<string>(new[] { "Hello", "World" });        // Initialize an empty Stack
            Stack<string> stack2 = new Stack<string>(["Hello", "World"]);        // Initialize an empty Stack

            Queue<string> queue1 = new Queue<string>(new[] { "Hello", "World" });        // Initialize an empty Queue
            Queue<string> queue2 = new Queue<string>(["Hello", "World"]);        // Initialize an empty Queue


        }

        public static void DoList(List<string> list)
        {
            list.Add("Hello");                          // Add a single element to the end of the list
            list.Insert(1, "World");                    // Insert an element at a specific index (1 in this case)
            list.AddRange("Coding", "Factory");         // Add multiple elements to the end of the list
            list.Remove("Hello");                       // Remove the first occurrence of "Hello" from the list
            list.RemoveAt(0);                           // Remove the element at index 0 (which is now "World")

            list[1] = "AUEB";                           // Update the element at index 1 to "AUEB"   
            string token = list[1];                     // Read - Access the element at index 0 and store it in a variable

            Console.WriteLine(list.Count);
            list.ForEach(x => Console.WriteLine(x));    // Iterate through the list and print each element



        }

        public static void DoLinkedList(LinkedList<string> linkedList)
        {
            linkedList.AddLast("Hello");
            linkedList.AddFirst("World");
            linkedList.AddAfter(linkedList.First!, "Coding");
            linkedList.AddBefore(linkedList.Last!, "Factory");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

        }


        public static void DoDictionary(Dictionary<string, int> dictionary)
        {
            dictionary.Add("one", 1);                      // Add a key-value pair to the dictionary
            dictionary["Two"] = 2;                        // Add or update a key-value pair using the indexer
            int one = dictionary["one"];                      // Read - Unsafe access, will throw KeyNotFoundException if "Hello" does not exist

            if (!dictionary.TryGetValue("two", out one))   // Safe access using TryGetValue, returns false if "Hello" does not exist
            {
                Console.WriteLine("Error");
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


        }


        public static void DoStack(Stack<string> stack)
        {
            stack.Push("Hello");                     // Add an element to the top of the stack
            stack.Push("World");                     // Add another element to the top of the stack

            string topElement = stack.Pop();                 // Remove and return the top element of the stack (which is "World")
            Console.WriteLine("topElement");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void DoQueue(Queue<string> queue)
        {
            queue.Enqueue("Hello");                   // Add an element to the end of the queue
            queue.Enqueue("World");                   // Add another element to the end of the queue
            string frontElement = queue.Dequeue();             // Remove and return the front element of the queue (which is "Hello")
            Console.WriteLine(frontElement);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }

        public static void DoHashSet(HashSet<string> hashSet)
        {
            var hashSet2 = new HashSet<string>() {"Hello", "Coding", "Factory"};        // Initialize a HashSet with a collection initializer

            hashSet.Add("Hello");                     // Add an element to the HashSet
            hashSet.Add("World");                     // Add another element to the HashSet
            hashSet.Add("Hello");                     // Attempt to add a duplicate element (will not be added)
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }

            hashSet.Union(hashSet2);                     // Perform a union operation with another HashSet (hashSet2) - adds all the unique elements from hashSet2 to hashSet
            hashSet.Intersect(hashSet2);                   // Perform an intersection operation with another HashSet (hashSet2) - retains only the elements that are present in both hashSet and hashSet2

        }

    }
}
