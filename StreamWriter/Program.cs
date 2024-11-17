string inputFile = args[0];
string outputFile = args[1];

try
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
catch (FileNotFoundException)
{
    Console.WriteLine($"Error: Input file '{inputFile}' not found.");
}
catch (IOException e)
{
    Console.WriteLine($"Error: An I/O error occurred: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Error: An unexpected error occurred: {e.Message}");
}