using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    class ObserverPattern
    {
    }

    /// <summary>
    /// 抽象主题角色（将所有观察者对象的引用保存在一个列表中、含有增加和删除观察者对象操作、包含调用抽象观察者的变更操作）
    /// </summary>
    public abstract class Subject
    {
        internal List<Observer> observers ;
        internal int Balance;
        /// <summary>
        /// 保存所有观察者对象
        /// </summary>
        public Subject(int balance)
        {
            observers = new List<Observer>();
            Balance = balance;
        }

        /// <summary>
        /// 增加观察者对象
        /// </summary>
        public abstract void Adds(Observer observer);

        /// <summary>
        /// 删除观察者对象
        /// </summary>
        public abstract void Removes(Observer observer);

        /// <summary>
        /// 通知观察者变化
        /// </summary>
        public void Notice() 
        {
            foreach (var item in observers)
            {
                if (item!=null)
                {
                    item.Change(this);
                }
            }
        }
    }

    /// <summary>
    /// 抽象观察者（为所有具体观察者提供了一个当主题通知是变更自己的操作）
    /// </summary>
    public abstract class Observer
    {
        
       
        public abstract void Change(Subject Item);
    }

    /// <summary>
    /// 具体主题角色，实现抽象角色抽象方法
    /// </summary>
    public class CallChargeSubject : Subject
    {
        public CallChargeSubject( int balance) : base( balance )
        {

        }
       
        public override void Adds(Observer observer)
        {
            observers.Add(observer);
        }

       

        public override void Removes(Observer observer)
        {
            observers.Remove(observer);
        }
    }

    /// <summary>
    /// 具体观察者
    /// </summary>
    public class CallChargeObserver : Observer
    {
        internal string Name;
        public CallChargeObserver(string name)  
        {
            Name = name;
        }
        public override void Change(Subject Item)
        {
            Console.WriteLine($"{Name}您好，您当前话费余额为：{Item.Balance},为了避免后续为您带来不便请及时充值!");
        }
    }
}
