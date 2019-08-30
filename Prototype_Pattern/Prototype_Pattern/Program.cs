using System;

namespace Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //学习
            Prototype learnPrototype = new LearnPrototype();
            learnPrototype.Status();
            learnPrototype.Action("一号在学习：语文");

            Prototype learnPrototype1 = learnPrototype.Clone();
            learnPrototype.Status();
            learnPrototype.Action("二号在学习：数学");

            //玩耍
            Prototype playPrototype = new PlayPrototype();
            playPrototype.Status();
            playPrototype.Action("一号在玩耍：游戏王");

            Prototype playPrototype1 = playPrototype.Clone();
            learnPrototype.Status();
            learnPrototype.Action("二号在玩耍：四驱赛车");

        }
    }
}
