/*
 * @Author: yk 
 * @Date: 2021-12-23 13:51:26 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:54:47
 */
using System;
using DISample.SetterInjection;
using DISample.ConstructorInjection;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 方法注入
            SetterInjection.IServiceClass serviceA1 = new SetterInjection.ServiceClassA();
            SetterInjection.IServiceClass serviceB1 = new SetterInjection.ServiceClassB();
            SetterInjection.ClientClass client1 = new SetterInjection.ClientClass();

            client1.SetServiceImple(serviceA1);
            client1.ShowInfo();
            client1.SetServiceImple(serviceB1);
            client1.ShowInfo();

            // 构造注入
            ConstructorInjection.IServiceClass serviceA2 = new ConstructorInjection.ServiceClassA();
            ConstructorInjection.IServiceClass serviceB2 = new ConstructorInjection.ServiceClassB();
            ConstructorInjection.ClientClass client2 = new ConstructorInjection.ClientClass(serviceA2);
            ConstructorInjection.ClientClass client3 = new ConstructorInjection.ClientClass(serviceB2);
            client2.ShowInfo();
            client3.ShowInfo();

            // 属性注入
            PropertyInjection.ClientClass client4 = new PropertyInjection.ClientClass();
            PropertyInjection.ClientClass client5 = new PropertyInjection.ClientClass();

            client4.MyServiceImple = new PropertyInjection.ServiceClassA();
            client4.ShowInfo();
            client5.MyServiceImple = new PropertyInjection.ServiceClassB();
            client5.ShowInfo();

            
        }
    }
}
