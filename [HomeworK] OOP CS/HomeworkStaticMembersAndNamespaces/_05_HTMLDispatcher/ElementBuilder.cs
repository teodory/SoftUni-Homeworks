using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private string atribues;
        private string contents;

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        private string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name value can't be null or empty");
                }
                this.name = value;
            }
        }

        public void AddAttribute(string attribute, string value) 
        {
            this.atribues += " " + attribute + "=\"" + value + "\"";
        }

        public void AddContent(string content)
        {
            contents += content;
        }

        public override string ToString()
        {
 	         return string.Format("<{0}{1}>{2}</{0}>", this.Name, this.atribues, this.contents);
        }

        public static string operator * (ElementBuilder e , int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
			{
			    result += e;
			}
            return result;
        }

    }
}
