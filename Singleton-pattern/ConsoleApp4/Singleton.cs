using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    /// <summary>
    /// 非线程安全
    /// </summary>
    public sealed class Singleton1
    {
        /// <summary>
        /// 定义静态变量保存实例
        /// </summary>
        public static Singleton1 Instance = null;

        /// <summary>
        /// 定义私有构造函数保护，使其他地方不得实例
        /// </summary>
        private Singleton1()
        { 
        }
        public string GetString()
        {
          return  "非线程安全的单例模式";
        } 

        /// <summary>
        /// 定义公共方法，实现全局访问
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstance()
        {
            //判断实例状态
            if (Instance==null)
            {
                Instance = new Singleton1();
            }
            return Instance;
        }
    }

    /// <summary>
    /// 线程安全单例模式
    /// </summary>
    public sealed class Singleton2
    {
        /// <summary>
        /// 定义静态变量保存实例
        /// </summary>
        public static Singleton2 Instance = null;

        private static readonly object locks=new object();

        /// <summary>
        /// 定义私有构造函数保护，使其他地方不得实例
        /// </summary>
        private Singleton2()
        {
        }
        public string GetString()
        {
            return "线程安全的单例模式";
        }
        /// <summary>
        /// 定义公共方法，实现全局访问
        /// </summary>
        /// <returns></returns>
        public static Singleton2 GetInstance()
        {
            //对线程进行加锁限制，挂起后来的线程。保证实例安全
            lock (locks)
            {
                if (Instance == null)
                {
                    Instance = new Singleton2();
                }
            } 
            return Instance;
        }
    }


    /// <summary>
    /// 不用锁线程安全单例模式
    /// </summary>
    public sealed class Singleton3
    {
        /// <summary>
        /// 定义静态变量保存实例
        /// </summary>
        private static readonly Singleton3 Instance = new Singleton3 ();

        static Singleton3()
        { }
        /// <summary>
        /// 定义私有构造函数保护，使其他地方不得实例
        /// </summary>
        private Singleton3()
        {
        }
        public string GetString()
        {
            return "不用锁线程安全单例模式";
        }
        /// <summary>
        /// 定义公共方法，实现全局访问
        /// </summary>
        /// <returns></returns>
        public static Singleton3 GetInstance()
        {   
            return Instance;
        }
    }

    /// <summary>
    /// 实现完全延迟加载单例模式
    /// </summary>
    public sealed class Singleton4
    {
        /// <summary>
        /// 定义私有构造函数保护，使其他地方不得实例
        /// </summary>
        private Singleton4()
        {
        }
        /// <summary>
        ///  提供访问位置
        /// </summary>
        public static Singleton4 Instance {
            get
            {
                return GetInstance.instance;
            }
        }
        /// <summary>
        /// 定义私有类确保第一次加载是初始化及调用
        /// </summary>
        private class GetInstance
        {
            static GetInstance(){}
            internal static readonly Singleton4 instance = new Singleton4();
        }
         
        public string GetString()
        {
            return "实现完全延迟加载单例模式";
        }
        
    }


    /// <summary>
    /// 使用Lazy<T>实现完全延迟加载单例模式
    /// </summary>
    public sealed class Singleton5
    {
        /// <summary>
        /// 延迟加载初始化
        /// </summary>
        private static readonly Lazy<Singleton5> lazy=new Lazy<Singleton5>(()=>new Singleton5());

        /// <summary>
        /// 定义私有构造函数保护，使其他地方不得实例
        /// </summary>
        private Singleton5()
        {
        }

        /// <summary>
        /// 提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static Singleton5 Instance()
        {
            return lazy.Value;
        }
        public string GetString()
        {
            return "实现完全延迟加载单例模式";
        }

    }
}
