using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class CommandPattern
    {
    }
    #region 命令接收者——具体操作 ===================
    /// <summary>
    /// 执行命令
    /// </summary>
    public class InfoReceiver
    {
        public void Delete()
        {
            Console.WriteLine("删除了第一条信息!");
        }
        public void Update()
        {
            Console.WriteLine("更新了第二天信息!");
        }
    }
    #endregion

    #region 命令请求者——控制命令 ===================
    /// <summary>
    /// 控制命令调用请求
    /// </summary>
    public class InfoInvoke
    {
        /// <summary>
        /// 记录上一个命令
        /// </summary>
        private Command lastCommand =null;
        /// <summary>
        /// 接收当前命令
        /// </summary>
        private Command _command = null;
        public InfoInvoke(Command command=null) 
        {
            this._command = command;
        }
        public string ExecuteInvoke()
        {
            if (_command==null&& lastCommand==null) 
                return ("无命令执行!");
            if (_command == null)
            {
                Console.WriteLine($"记录此操作记录{_command.GetType().Name}的撤销操作!");
                _command = lastCommand;
                return ("执行撤销操作!");
            }
            Console.WriteLine($"记录此操作记录{_command.GetType().Name}!");
            _command.Execute();
            return ("执行成功!");
        }
    }
    #endregion

    #region 命令角色——抽象命令 =====================
    /// <summary>
    /// 抽象命令 持有命令接收者，调用接收者执行命令
    /// </summary>
    public abstract class Command
    {
        protected InfoReceiver _infoReceiver;
        public Command(InfoReceiver infoReceiver)
        {
            this._infoReceiver = infoReceiver;
        }
        public abstract void Execute();
    }
    #endregion

    #region 具体命令角色——调用接收者 ===============
    /// <summary>
    /// 实现抽象角色
    /// </summary>
    public class InfoCommandDelete : Command
    { 
        public InfoCommandDelete(InfoReceiver infoReceiver) : base(infoReceiver) { }
        public override void Execute()
        {
            _infoReceiver.Delete();
        }
    }
    #endregion

    #region 具体命令角色——调用接收者 ===============
    /// <summary>
    /// 实现抽象角色
    /// </summary>
    public class InfoCommandUpdate : Command
    {
        public InfoCommandUpdate(InfoReceiver infoReceiver) : base(infoReceiver) { }
        public override void Execute()
        {
            _infoReceiver.Update();
        }
    }
    #endregion
}
