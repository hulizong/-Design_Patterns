using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{ 

    #region 外观角色
    public class FacadePattern
    {
        private RegisteredClass registeredClass;
        private LoginClass loginClass;
        private SendClass sendClass;
        public FacadePattern() 
        {
             registeredClass = new RegisteredClass();
            loginClass = new LoginClass();
            sendClass = new SendClass();
        }
        public  void LoginFirst() 
        {
            registeredClass.Registered();
            loginClass.Login();
            sendClass.Send();
        }
    }
    #endregion

    #region 子系统
    public class RegisteredClass 
    {
        public  void Registered() 
        {
            Console.WriteLine("注册成功");
        }
    }
    public class LoginClass 
    {
        public  void Login()
        {
            Console.WriteLine("登录成功");
        }
    }
    public class SendClass 
    {
        public  void Send()
        {
            Console.WriteLine("赠送成功");
        }
    }
    #endregion
}
