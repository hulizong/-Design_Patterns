using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    class UseVisitorPattern
    {
    }

    #region 访问者

    /// <summary>
    /// 抽象访问者
    /// </summary>
    public interface IVistor 
    {
        void Visit(UseRectangle rectangle);
        void Visit(UseCircular  useCircular);
    }

    /// <summary>
    /// 具体访问者
    /// </summary>
    public class Vistor : IVistor
    {
        public void Visit(UseRectangle rectangle)
        {
            rectangle.CalculatedArea();
            Console.WriteLine($"长方形长是：{rectangle._long}");
            Console.WriteLine($"长方形宽是：{rectangle._wide}");
            Console.WriteLine($"长方形周长是：{2*(rectangle._long+rectangle._wide)}");
        }

        public void Visit(UseCircular useCircular)
        {
            useCircular.CalculatedArea();
            Console.WriteLine($"圆形的半径是：{useCircular._r}");
            Console.WriteLine($"圆形的周长是是：{2*Math.PI*useCircular._r}");
        }
    }

    #endregion

    #region 节点类

    /// <summary>
    /// 抽象节点类
    /// </summary>
    public abstract class UseElement
    {
        public abstract void Accept(IVistor vistor);
        public abstract void CalculatedArea();
    }

    /// <summary>
    /// 长方形计算面积输出
    /// </summary>
    public class UseRectangle : UseElement
    {
        public double _long;
        public double _wide;

        public UseRectangle(double Long, double Wide)
        {
            this._long = Long;
            this._wide = Wide;
        }

        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }

        public override void CalculatedArea()
        {
            Console.WriteLine($"长方形面积是：{_long * _wide}");
        }
    }

    /// <summary>
    /// 圆形计算面积输出
    /// </summary>
    public class UseCircular : UseElement
    {
        public double _r;

        public UseCircular(double r)
        {
            this._r = r;
        }
        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }
        public override void CalculatedArea()
        {
            Console.WriteLine($"圆形面积是：{Math.PI * _r * _r}");
        }
    }

    #endregion

    /// <summary>
    /// 结构对象
    /// </summary>
    public class UseGraphical
    {
        public List<UseElement> elements = new List<UseElement>();
        public List<UseElement> Elements
        {
            get { return elements; }
        }

        public UseGraphical()
        {
            UseElement element = new UseRectangle(10, 5);
            UseElement element1 = new UseCircular(5);
            elements.Add(element);
            elements.Add(element1);
        }
    }
}
