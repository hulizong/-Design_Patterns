using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace State_Pattern
{
    /// <summary>
    /// 房屋对象类
    /// </summary>
  public  class StatePattern
    {
        /// <summary>
        /// 房屋Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 房屋名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 租房时间/月
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// 房屋状态
        /// </summary>
        public HouseState State { get; set; }
        /// <summary>
        /// 是否退押金
        /// </summary>
        public bool IsDeposit { get; set; }
    }

    /// <summary>
    /// 房屋出租状态枚举
    /// </summary>
    public enum HouseState 
    {
        [Description("出租")]
        Lease =1,
        [Description("签订合同")]
        Leaseed = 2,
        [Description("退房")]
        Deposit = 3, 
    }

    /// <summary>
    /// 环境角色
    /// </summary>
    public class Environmental
    {
        public State _state;

        /// <summary>
        /// 初始化房屋状态
        /// </summary>
        public Environmental()
        {
            this._state = new LeaseState();
        }

        public StatePattern _statePattern { get; set; }

        /// <summary>
        /// 获取房屋对象
        /// </summary>
        /// <param name="statePattern"></param>
        public void GetStatePattern(StatePattern statePattern,State state=null)
        {
            _statePattern = statePattern;
            if (state!=null)
            {
                _state =  state;
            }
        }

        /// <summary>
        /// 更改状态方法
        /// </summary>
        /// <param name="state"></param>
        public void SetState(State state) 
        {
            _state = state;
        }

        public void Show() 
        {
            if (this._statePattern!=null)
            {
                _state.Handle(this);
            }
            else
            {
                Console.WriteLine("无可操作房屋!");
            }
        }
    }

    /// <summary>
    /// 抽象状态接口
    /// </summary>
    public interface  State 
    {
        void Handle(Environmental environmental);
    }

    /// <summary>
    /// 出租状态
    /// </summary>
    public class LeaseState : State
    {
        public void Handle(Environmental environmental)
        {
              
            //房屋出租
            if (environmental._statePattern.State==HouseState.Lease)
            {
                Console.WriteLine($"{environmental._statePattern.Name}房屋正在出租!");
                Console.WriteLine("如果觉得可以的话就签订租房合同!"); 
                environmental.SetState(new LeaseedState());
                environmental.Show();
            }
        }
    } 

    /// <summary>
    /// 签订合同状态
    /// </summary>
    public class LeaseedState : State
    {
        public void Handle(Environmental environmental)
        {
             
            
            //后期办理退房手续
            if (environmental._statePattern.State == HouseState.Lease)
            {
                Console.WriteLine($"{environmental._statePattern.Name}签订租房合同!");
                environmental._statePattern.State = HouseState.Leaseed;
                environmental._statePattern.Time = 1;
                environmental.SetState(new DepositState());
                environmental.Show();
            }
        }
    }

 

    /// <summary>
    /// 退房有押金状态
    /// </summary>
    public class DepositState : State
    {
        public void Handle(Environmental environmental)
        {
            environmental._statePattern.IsDeposit = true;
            if (environmental._statePattern.State == HouseState.Leaseed && environmental._statePattern.Time < 6)
            {
                Console.WriteLine($"{environmental._statePattern.Name}如果现在退房的话是不能退押金的!");
                environmental._statePattern.IsDeposit = false;
            }
            else
                Console.WriteLine($"{environmental._statePattern.Name}如果现在退房的话是可以退押金的!");
            Console.WriteLine("考虑是否退房!");
        }
    }
}
