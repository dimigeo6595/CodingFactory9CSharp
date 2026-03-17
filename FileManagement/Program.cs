namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList<char> dll = new();
            ListNode<char>? node;
            int totatChars = 0;
            string filePath = @"C:\tmp\file.txt";
            int ordinal;
            char ch;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File does not exist: {filePath}");
                    return;
                }

                using StreamReader reader = new(filePath);

                while ((ordinal = reader.Read()) != -1)
                {
                    ch = (char)ordinal;
                    if (ch is '\r' or '\n') continue;

                    node = dll.FindNode(ch);
                    if (node is null)
                    {
                        dll.InsertLast(ch);

                    }
                    else
                    {
                        dll.IncreaseCount(ch);
                    }
                    totatChars++;
                }

                dll.SortByCount();
                dll.Traverse(totatChars);

            }
            catch (IOException ex) 
            {

                Console.WriteLine(ex.Message);

            }
        }
    }
}
