using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new CallChargeSubject(10);
            subject.Adds(new CallChargeObserver("张三"));
            subject.Adds(new CallChargeObserver("李四"));
            subject.Notice();
        }
    }
}
