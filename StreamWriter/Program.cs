class Program
{
    static void Main(string[] args)
    {
        string inputFile = args[0];
        string outputFile = args[1];

        try
        {
            InsertLineNumbers(inputFile, outputFile);
            Console.WriteLine($"Line numbers inserted. Output saved to {outputFile}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void InsertLineNumbers(string inputFile, string outputFile)
    {
        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            int lineNumber = 1;
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine($"{lineNumber,4}: {line}");
                lineNumber++;
            }
        }
    }
}