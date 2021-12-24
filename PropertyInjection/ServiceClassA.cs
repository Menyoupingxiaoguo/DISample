/*
 * @Author: yk 
 * @Date: 2021-12-23 13:40:02 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:53:49
 */
using System;
namespace DISample.PropertyInjection
{
    internal class ServiceClassA : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是PropertyInjection_ServiceClassA";
        }
    }
}