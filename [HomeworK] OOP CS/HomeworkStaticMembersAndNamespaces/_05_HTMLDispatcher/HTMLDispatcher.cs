using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HTMLDispatcher
{
    static class HTMLDispatcher
    {

        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder el = new ElementBuilder("img");
            el.AddAttribute("src", imageSource);
            el.AddAttribute("alt", alt);
            el.AddAttribute("title", title);
            return el.ToString();
        } 

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder el = new ElementBuilder("a");
            el.AddAttribute("href", url);
            el.AddAttribute("title", title);
            el.AddContent(text);
            return el.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder el = new ElementBuilder("input");
            el.AddAttribute("type", inputType);
            el.AddAttribute("name", name);
            el.AddAttribute("value", value);
            return el.ToString();
        
        }


      
    }
}
