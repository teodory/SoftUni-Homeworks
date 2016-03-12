using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HTMLDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {

          
            ElementBuilder div = new ElementBuilder("div");

            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div * 2);

            string image = HTMLDispatcher.CreateImage("img.png", "sample img", "sample");
            string url = HTMLDispatcher.CreateURL("https:\\\\softuni.bg", "SoftUni", "SoftUni website");
            string input = HTMLDispatcher.CreateInput("text", "username", "student");

            Console.WriteLine(image);
            Console.WriteLine(url);
            Console.WriteLine(input);

        }
    }
}
