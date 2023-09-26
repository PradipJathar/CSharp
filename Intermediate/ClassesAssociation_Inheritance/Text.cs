using System;

namespace ClassesAssociation_Inheritance
{
    public class Text : PresentaionObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine($"We added link to {url}");
        }
    }
}
