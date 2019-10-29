using System;

namespace Interpreter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("三加八加九减二乘五除三");
            AbstractExpression abstractExpression = new TerminalExpression();
             abstractExpression.Interpret(context);

            AbstractExpression noabstractExpression = new NonterminalExpression();
             noabstractExpression.Interpret(context);

            Console.WriteLine(context.Statement);
        }
    }
}
