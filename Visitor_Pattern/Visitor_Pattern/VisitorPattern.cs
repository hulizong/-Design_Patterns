using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    class VisitorPattern
    {
    }

    /// <summary>
    /// 抽象节点类
    /// </summary>
    public abstract class Element 
    {
       public abstract void CalculatedArea();
    }

    /// <summary>
    /// 长方形计算面积输出
    /// </summary>
    public class Rectangle : Element
    {
        public double _long;
        public double _wide;

        public  Rectangle(double Long, double Wide) 
        {
            this._long = Long;
            this._wide = Wide;
        }
        public override void CalculatedArea()
        {
            Console.WriteLine($"长方形面积是：{_long*_wide}");
        }
    }

    /// <summary>
    /// 圆形计算面积输出
    /// </summary>
    public class Circular : Element
    {
        public double _r; 

        public Circular(double r)
        {
            this._r = r; 
        }
        public override void CalculatedArea()
        {
            Console.WriteLine($"圆形面积是：{Math.PI * _r*_r}");
        }
    }

    /// <summary>
    /// 结构对象
    /// </summary>
    public class Graphical 
    {
        public List<Element> elements = new List<Element>();
        public List<Element> Elements
        {
            get { return elements; }
        }

        public Graphical() 
        {
            Element element = new Rectangle(10,5);
            Element element1= new Circular(5);
            elements.Add(element);
            elements.Add(element1);
        }
    }
}
