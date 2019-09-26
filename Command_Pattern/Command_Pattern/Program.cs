using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///初始化命令接收者和命令请求者还有具体命令
            InfoReceiver infoReceiver = new InfoReceiver();

            InfoCommandDelete infoCommandDelete = new InfoCommandDelete(infoReceiver);

            InfoInvoke infoInvoke = new InfoInvoke(infoCommandDelete);
            var result=infoInvoke.ExecuteInvoke();

            Console.WriteLine(result);

        }
    }
}
