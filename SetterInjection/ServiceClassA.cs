/*
 * @Author: yk 
 * @Date: 2021-12-23 13:40:02 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:54:06
 */
using System;
namespace DISample.SetterInjection
{
    internal class ServiceClassA : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是SetterInjection_ServiceClassA";
        }
    }
}