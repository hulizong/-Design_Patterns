using Composite_Pattern1;
using System;

namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //操作树叶本身文件
            Files bookTxt = new BookTxt();
            bookTxt.Open("文本文件一");

            //新增文件夹
            Files subFiles = new SubFiles();
            subFiles.Open("文件一");
            subFiles.Add(new SubFiles(), "文件二");

            //删除文件
            subFiles.Remove(Name: "文本文件二");

            Console.ReadLine();
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            //操作树叶本身文件
            BookTxt bookTxt = new BookTxt();
            bookTxt.Open("文本文件一");

            //新增文件夹
            AbSubFiles subFiles = new AbSubFiles();
            subFiles.Open("文件一");
            subFiles.Add(new AbSubFiles(), "文件二");

            //删除文件
            subFiles.Remove(Name: "文本文件二");

            Console.ReadLine();

        }
    }
}
