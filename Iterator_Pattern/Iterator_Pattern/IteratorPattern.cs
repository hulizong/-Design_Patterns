using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Pattern
{
    class IteratorPattern
    {
    }

    /// <summary>
    /// 抽象聚合类、包含一个创建迭代器对象的方法
    /// </summary>
    public interface IListAggregate
    {
        Iterator GetIterator();
    }

    /// <summary>
    /// 抽象迭代器、包含访问和遍历元素的方法
    /// </summary>
    public interface Iterator
    {
        /// <summary>
        /// 是否有下一个元素
        /// </summary>
        /// <returns></returns>
        bool IsNext();
        /// <summary>
        /// 获取当前元素位置
        /// </summary>
        /// <returns></returns>
        object GetCurrentIndex();
        /// <summary>
        /// 获取下一个元素
        /// </summary>
        void Next();
        /// <summary>
        /// 获取第一个元素、相当于重置
        /// </summary>
        void Start();
    }

    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ConcreteListAggregate : IListAggregate
    { 
        string[] list;
        public ConcreteListAggregate()
        {
            list = new string[] { "张三", "李四", "王五", "赵六" };
        }

        /// <summary>
        /// 创建迭代器对象
        /// </summary>
        /// <returns></returns>
        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// 获取对象长度
        /// </summary>
        public int Length
        {
            get { return list.Length; }
        }

        /// <summary>
        /// 获取指定位置元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object GetItem(int index)
        {
            return list[index];
        } 
    }

    public class ConcreteIterator : Iterator
    {
        private ConcreteListAggregate _list;
        private int _index;

        public ConcreteIterator(ConcreteListAggregate list)
        {
            _list = list;
            _index = 0;

        }

        public object GetCurrentIndex()
        {
            return _list.GetItem(_index);
        }

        public bool IsNext()
        {
            if (_index<_list.Length)
            {
                return true;
            }
            return false;
        }

        public void Next()
        {
            if (_index<_list.Length)
            {
                _index++;
            }
        }

        public void Start()
        {
            _index = 0;
        }
    }
}
