using ServiceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithT4.Reflection
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

            Console.Title = "Playing with T4";
            Console.WriteLine($"The current window is: {aModel.WindowName} with a width of: {aModel.Width} and a Height of: {aModel.Height}, you are welcome.");

            var entitiesNamespace = "ServiceModel.Models";
            var entitiesAssembly = @"C:\Users\Erick Asto\Documents\DEV\UCSP\CI\testprojects\PlayingWithT4\PlayingWithT4.Reflection\bin\Debug\ServiceModel.dll";

            var tinyEntitiesName = "ServiceModel.dll";
            var assembly = LoadFromFile(tinyEntitiesName);

            var typesToRegister =
                from t in Assembly.LoadFile(entitiesAssembly).GetExportedTypes()
                where t.Namespace == entitiesNamespace && t.IsClass && !t.IsAbstract
                select t;

            foreach (var iObject in typesToRegister)
            {
                Console.WriteLine($"El objeto encontrado es: {iObject.Name}");
            }
            Console.ReadKey();
        }

        private static Assembly LoadFromFile(string relativePath)
        {
            string finalPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, relativePath);
            return Assembly.LoadFile(finalPath);
        }
    }
}
