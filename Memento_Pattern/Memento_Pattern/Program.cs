using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento_Pattern
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    ///初始化数据
        //    List<Photo> photos = new List<Photo>();
        //    photos.Add(new Photo { Name = "第一张.jpg", Address = "https://img2018.cnblogs.com/blog/1470432/201910/11.jpg" });
        //    photos.Add(new Photo { Name = "第二张.jpg", Address = "https://img2018.cnblogs.com/blog/1470432/201910/22.jpg" });
        //    photos.Add(new Photo { Name = "第三张.jpg", Address = "https://img2018.cnblogs.com/blog/1470432/201910/33.jpg" });
        //    Sponsor sponsor = new Sponsor(photos);

        //    ///展示数据
        //    sponsor.ShowPhoto();

        //    ///保存状态数据到备忘录
        //    MementoManager mementoManager = new MementoManager();
        //    mementoManager.memento = sponsor.CreateMemento();

        //    ///删除一张照片
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    photos.RemoveAt(0);
        //    sponsor.GetPhotos = photos;
        //    Console.WriteLine("删除后");
        //    sponsor.ShowPhoto();

        //    ///恢复备忘录数据
        //    ///
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    sponsor.RestoreMemento(mementoManager.memento);
        //    Console.WriteLine("恢复后");
        //    sponsor.ShowPhoto();

        //}
        static void Main(string[] args)
        {
            ///初始化数据
            List<Photo> photos = new List<Photo>();
            photos.Add(new Photo { Name = "第一张.jpg", Address = "https://img2018.cnblogs.com/blog/1470432/201910/11.jpg" });
            photos.Add(new Photo { Name = "第二张.jpg", Address = "https://img2018.cnblogs.com/blog/1470432/201910/22.jpg" });
            photos.Add(new Photo { Name = "第三张.jpg", Address = "https://img2018.cnblogs.com/blog/1470432/201910/33.jpg" });
            Sponsor sponsor = new Sponsor(photos);

            ///展示数据
            sponsor.ShowPhoto();

            ///保存状态数据到备忘录
            MementoManagers mementoManagers = new MementoManagers();
            mementoManagers.mementoList.Add("1", sponsor.CreateMemento()); 

            ///删除一张照片
            Console.WriteLine();
            Console.WriteLine();
            photos.RemoveAt(0);
            sponsor.GetPhotos = photos;
            Console.WriteLine("删除后");
            sponsor.ShowPhoto();
            mementoManagers.mementoList.Add("2", sponsor.CreateMemento());

            ///恢复备忘录数据
            ///
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"目前有{mementoManagers.mementoList.Count}个备份数据,请输入序号选择备份数据恢复");
                var index = Console.ReadLine();
                sponsor.RestoreMemento(mementoManagers.mementoList.GetValueOrDefault(index));
                Console.WriteLine("恢复后");
                sponsor.ShowPhoto();
                Console.WriteLine("输入q退出");
                var q = Console.ReadLine();
                if (q=="q")
                {
                    break;
                }
            }
           

        }
    }
}
