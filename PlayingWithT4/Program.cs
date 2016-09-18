using ServiceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithT4
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowModel aModel = new WindowModel()
            {
                Height = 200,
                Host = "Test Project",
                Width = 800,
                WindowName = "A Simple Test"
            };

            PageModel aPageModel = new PageModel()
            {
                PageDescription = "La la la",
                PageId = 234
            };


            Console.Title = "Playing with T4";
            Console.WriteLine($"The current window is: {aModel.WindowName} with a width of: {aModel.Width} and a Height of: {aModel.Height}, you are welcome.");


            var entitiesNamespace = "ServiceModel.Models";
            var entitiesAssembly = "ServiceModel.dll";
            var typesToRegister =
                from t in Assembly.LoadFrom(@"C:\Users\Erick Asto\Documents\DEV\UCSP\CI\testprojects\PlayingWithT4\ServiceModel\LibForT4\ServiceModel.dll").GetTypes()
                //where t.Namespace == entitiesNamespace && t.IsClass && !t.IsAbstract
                select t;

            foreach (var type in typesToRegister.Where(t => t.IsClass && !t.IsAbstract))
            {
                Console.WriteLine("Why?");
            }

                Console.ReadKey();
        }
    }
}
