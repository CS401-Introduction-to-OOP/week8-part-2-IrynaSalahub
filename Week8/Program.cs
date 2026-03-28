
using System.Resources;
using Week8;

class Program
{
    public static void Main()
    {
        using (ResourceManager<Resource> manager = new ResourceManager<Resource>())
               {
                   var file = new FileResource("report.txt");
                   var network = new NetworkResource("api.company.local");
                   manager.Add(file);
                   manager.Add(network);
                   manager.OpenAll();
                   using (FileResource singleFile = new FileResource("temp.log"))
                   {
                       singleFile.Open();
                   }
                   manager.CloseAll();
               }
        Console.WriteLine("Done");
    }
}