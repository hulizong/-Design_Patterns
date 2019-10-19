using System;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Graphical graphical = new Graphical();
            //foreach (var item in graphical.Elements)
            //{
            //    item.CalculatedArea();
            //}
            UseGraphical graphical = new UseGraphical();
            foreach (var item in graphical.Elements)
            {
                item.Accept(new Vistor());
            }
        }
    }
}
