/*
 * @Author: yk 
 * @Date: 2021-12-23 13:42:11 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:54:05
 */
using System;
namespace DISample.SetterInjection
{
    internal class ServiceClassB : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是SetterInjection_ServiceClassB";
        }
    }
}