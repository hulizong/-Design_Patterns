using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    /// <summary>
    /// 透明式组合模式
    /// </summary>
    class CompositePattern
    {
    }

    #region 抽象构件角色——抽象文件目录============
    public abstract class Files 
    { 
        /// <summary>
        /// 增加子对象
        /// </summary>
        public abstract void Add(Files files = null, string Name = null);
        /// <summary>
        /// 删除子对象
        /// </summary>
        public abstract void Remove(Files files=null, string Name = null);
        /// <summary>
        /// 操作本身对象
        /// </summary>
        public abstract void Open(string Name);
    }
    #endregion

    #region 树叶构件——文件类型========================
    /// <summary>
    /// TXT文本
    /// </summary>
    public sealed class BookTxt : Files
    { 
        public override void Add(Files files=null, string Name = null)
        {
            throw new NotImplementedException("不存在添加子类操作");
        }
        public override void Remove(Files files=null, string Name = null)
        {
            throw new NotImplementedException("不存在删除子类操作");
        }

        public override void Open(string Name)
        {
            Console.WriteLine($"打开一个名为【{Name}】txt文本");
        }

        
    }
    #endregion

    #region 树枝构件——文件夹类型=================
    public class SubFiles : Files
    {
     
        public override void Add(Files files=null, string Name = null)
        {
            if (files != null)
            {
                Console.WriteLine($"添加一个名为【{Name}】的文件夹");
            }
            else
            {
                Console.WriteLine($"添加一个名为【{Name}】的txt文本");
            }
           
        }

        public override void Remove(Files files=null, string Name = null)
        {
            if (files != null )
            {
                Console.WriteLine($"删除一个名为【{Name}】的文件夹");
            }
            else
            {
                Console.WriteLine($"删除一个名为【{Name}】的txt文本");
            }
        }

        public override void Open(string Name)
        {
            Console.WriteLine($"打开当前名为【{Name}】文件夹文件夹");
        }

    }
    #endregion
}

namespace Composite_Pattern1
{
    /// <summary>
    /// 安全式组合模式
    /// </summary>
    class CompositePattern
    {
    }

    #region 抽象构件角色——抽象文件目录============
    public abstract class Files
    { 
        /// <summary>
        /// 操作本身对象
        /// </summary>
        public abstract void Open(string Name);
    }
    #endregion

    #region 树叶构件——文件类型========================
    /// <summary>
    /// TXT文本
    /// </summary>
    public sealed class BookTxt : Files
    {

        public override void Open(string Name)
        {
            Console.WriteLine($"打开一个名为【{Name}】txt文本");
        }


    }
    #endregion

    #region 抽象树枝构件——安全模式，开始定义子类对象操作接口和行为=================
    public abstract  class SubFiles : Files
    {

        public abstract void Add(Files files = null, string Name = null);

        public abstract void Remove(Files files = null, string Name = null);

        public override void Open(string Name)
        {
            Console.WriteLine($"打开当前名为【{Name}】文件夹");
        }

    }
    #endregion

    #region 具体树枝构件——具体实现类
    public class AbSubFiles : SubFiles
    {
        public override void Add(Files files = null, string Name = null)
        {
            if (files != null)
            {
                Console.WriteLine($"添加一个名为【{Name}】的文件夹");
            }
            else
            {
                Console.WriteLine($"添加一个名为【{Name}】的txt文本");
            }
        }

        public override void Remove(Files files = null, string Name = null)
        {
            if (files != null)
            {
                Console.WriteLine($"删除一个名为【{Name}】的文件夹");
            }
            else
            {
                Console.WriteLine($"删除一个名为【{Name}】的txt文本");
            }
        }
        public override void Open(string Name)
        {
            Console.WriteLine($"打开当前名为【{Name}】文件夹");
        }
    }
    #endregion
}
