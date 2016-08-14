using ServiceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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


            Console.Title = "Playing with T4";
            Console.WriteLine($"The current window is: {aModel.WindowName} with a width of: {aModel.Width} and a Height of: {aModel.Height}, you are welcome.");
            Console.ReadKey();
        }
    }
}
