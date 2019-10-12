using System;
using System.Collections.Generic;
using System.Linq;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化房源信息
            List<StatePattern> statePatterns = new List<StatePattern>();
            statePatterns.Add(new StatePattern {Id=1,Name="房屋一",State=HouseState.Lease }); 

            Environmental environmental = new Environmental();
            //房屋一出租
            environmental.GetStatePattern(statePatterns.Where(x=>x.Id==1).FirstOrDefault());
            environmental.Show();

            //时间大于半年可退押金
            statePatterns[0].Time = 7;
            environmental.Show();


        }
    }
}
