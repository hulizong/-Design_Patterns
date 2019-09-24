using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    class TemplateMethodPattern
    {
    }
    #region
    /// <summary>
    /// 抽象类型
    /// </summary>
    public abstract class WriteArticle
    {
        /// <summary>
        /// 这个就是模板方法，定义了写文章的顺序。这里不能使用抽象和Virtual，防止其子类修改执行顺序。
        /// </summary>
        public void Article()
        {
            OpenEditor();
            Write();
            Release();
            Console.WriteLine("文章完成了并发布了!");
        }
        /// <summary>
        /// 打开编辑器
        /// </summary>
        public void OpenEditor()
        {
            Console.WriteLine("打开编辑器");
        }
        /// <summary>
        /// 开始写文章，其子类具体实现文章内容
        /// </summary>
        public abstract void Write();
        /// <summary>
        /// 发布文章
        /// </summary>
        public void Release()
        {
            Console.WriteLine("发布文章");
        }
    }
    #endregion
    /// <summary>
    /// 技术文章
    /// </summary>
    public class TchnologyArticle : WriteArticle
    {
        public override void Write()
        {
            Console.WriteLine("设计模式相关的文章");
        }
    }
    /// <summary>
    /// 生活文章
    /// </summary>
    public class LifeArticle : WriteArticle
    {
        public override void Write()
        {
            Console.WriteLine("生活文章");
        }
    }

}
