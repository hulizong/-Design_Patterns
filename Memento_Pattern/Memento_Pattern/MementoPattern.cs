using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Pattern
{
    class MementoPattern
    {
    }
    #region 照片数据

    public class Photo 
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }
    #endregion

    #region  发起人角色

    public sealed class Sponsor 
    {
        private List<Photo> _photo;
        public Sponsor(List<Photo> photos) 
        {
            if (photos == null)
                throw new Exception("请传入正确的数据源!");
            this._photo = photos;
        }
        public List<Photo> GetPhotos
        {
            get { return this._photo; }
            set { this._photo = value; }
        }

        /// <summary>
        /// 创建备忘录，保存状态数据
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento() 
        {
            return new Memento(new List<Photo>(this._photo));
        }

        /// <summary>
        /// 获取备忘录数据、恢复状态数据
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(Memento memento) 
        {
            GetPhotos = memento._mementoList;
        }

        /// <summary>
        /// 展示数据
        /// </summary>
        public void ShowPhoto() 
        {
            Console.WriteLine($"目前用有照片{GetPhotos.Count}张：");
            foreach (var item in GetPhotos)
            {
                Console.WriteLine($"照片名称：{item.Name}。照片地址：{item.Address}");
            }
        }
    }
    #endregion

    #region   备忘录
    public sealed class Memento 
    {
        public List<Photo> _mementoList { get; private set; }

        /// <summary>
        /// 初始化存储数据
        /// </summary>
        /// <param name="MementoList"></param>
        public Memento(List<Photo> MementoList)
        {
            this._mementoList = MementoList;
        }

    }
    #endregion

    #region  管理员
    /// <summary>
    /// 一个备忘录数据处理
    /// </summary>
    public sealed class MementoManager 
    {
        public Memento  memento { get; set; }
    }

    /// <summary>
    /// 多个备忘录数据处理
    /// </summary>
    public sealed class MementoManagers
    {
        public Dictionary<string, Memento> mementoList { get; set; }
        public MementoManagers() 
        {
            mementoList = new Dictionary<string, Memento>();
        }
    }
    #endregion
}
