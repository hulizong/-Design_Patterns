using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class BuilderPattern
    {
    }
    #region 产品角色——电脑的组成 ============
    public class Computer
    {
        private string Type = null;
        public Computer(string type)
        {
            this.Type = type;
        }
        private List<string> computer = new List<string>();
        public void Add(string part)
        {
            computer.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑组装正式开始：");
            foreach (var item in computer)
            {
                Console.WriteLine("配件——" + item + "已装好");
            }
            Console.WriteLine(Type + "电脑组装完成了");
        }
    }
    #endregion

    #region 抽象创建者——电脑中的各个部分的抽象接口============

    public abstract class Builder
    {
        /// <summary>
        /// Cpu抽象创建
        /// </summary>
        public abstract void CreateCpu();
        /// <summary>
        /// 主板抽象创建
        /// </summary>
        public abstract void CreateMotherboard();
        /// <summary>
        /// 显卡抽象创建
        /// </summary>
        public abstract void CreateGraphicsCard();
        /// <summary>
        /// 获取组装好的电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();

    }
    #endregion

    #region 具体产品创建者——联想电脑各个部分创建接口=========
    public class LenovoBuilder : Builder
    {
        Computer lenovo = new Computer("联想");
        public override void CreateCpu()
        {
            lenovo.Add("联想CPU");
        }
        public override void CreateMotherboard()
        {
            lenovo.Add("联想主板");
        }
        public override void CreateGraphicsCard()
        {
            lenovo.Add("联想显卡");
        }

        public override Computer GetComputer()
        {
            return lenovo;
        }
    }
    #endregion

    #region 具体产品创建者——惠普电脑各个部分创建接口=========
    public class HPBuilder : Builder
    {
        Computer hp = new Computer("惠普");
        public override void CreateCpu()
        {
            hp.Add("惠普CPU");
        }
        public override void CreateMotherboard()
        {
            hp.Add("惠普主板");
        }
        public override void CreateGraphicsCard()
        {
            hp.Add("惠普显卡");
        }

        public override Computer GetComputer()
        {
            return hp;
        }
    }
    #endregion

    #region 指挥者——固定的组装算法=================== 
    /// <summary>
    /// 指挥者，其中的Construct是组装的较为固定算法
    /// </summary>
    public class Commander
    {
        public void Construct(Builder builder)
        {
            builder.CreateMotherboard();
            builder.CreateCpu();
            builder.CreateGraphicsCard();
        }
    }
    #endregion
}
