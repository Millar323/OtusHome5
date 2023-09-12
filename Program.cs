// See https://aka.ms/new-console-template for more information
using OtusHome5;

internal class Program
{

    private static void Main(string[] args)
    {
        List<Numbers> numbers = new List<Numbers> 
        {
            new Numbers{ Id = 1 },
            new Numbers{ Id = 2 },
            new Numbers{ Id = 3 },
        };

        var maxElement = Max.GetMax(numbers, (Product) => Product.Id);

        var file = new FileSearcher();
        file.FileFound += (_, fileArgs) => Console.WriteLine("File found: " + fileArgs); ;
        file.FilesSearch("D:\\files");

    }

    public class Numbers 
    {
        public int Id { get; set; }
    }
}