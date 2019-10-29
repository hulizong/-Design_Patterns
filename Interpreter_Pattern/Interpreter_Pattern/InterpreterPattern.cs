using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class InterpreterPattern
    {
    }
    /// <summary>
    /// Context: 环境类
    /// </summary>
    public class Context
    {
        private string _statement;
        public Context(string statement)
        {
            this._statement = statement;
            contextMap.Add("一", 1);
            contextMap.Add("二", 2);
            contextMap.Add("三", 3);
            contextMap.Add("四", 4);
            contextMap.Add("五", 5);
            contextMap.Add("六", 6);
            contextMap.Add("七", 7);
            contextMap.Add("八", 8);
            contextMap.Add("九", 9);
        }
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }
        public Dictionary<string, int> contextMap = new Dictionary<string, int>();


    }

    /// <summary>
    /// AbstractExpression: 抽象表达式
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Statement!=null)
            {
                foreach (var Key in context.contextMap.Keys)
                {
                    if (context.Statement.Contains(Key))
                    {
                        context.Statement= context.Statement.Replace(Key, context.contextMap[Key].ToString());// context.contextMap[Key]);
                    }
                }
            }
            //return context;
        }
    }

    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Statement.Contains("加"))
            {
                context.Statement= context.Statement.Replace("加","+");
            }
            if (context.Statement.Contains("减"))
            {
                context.Statement= context.Statement.Replace("减", "-");
            }
            if (context.Statement.Contains("乘"))
            {
                context.Statement= context.Statement.Replace("乘", "*");
            }
            if (context.Statement.Contains("除"))
            {
                context.Statement= context.Statement.Replace("除", "/");
            }
            //return context;
        }
    }

}
