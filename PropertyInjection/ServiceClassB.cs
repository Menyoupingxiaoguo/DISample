/*
 * @Author: yk 
 * @Date: 2021-12-23 13:42:11 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:53:53
 */
using System;
namespace DISample.PropertyInjection
{
    internal class ServiceClassB : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是PropertyInjection_ServiceClassB";
        }
    }
}