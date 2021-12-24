/*
 * @Author: yk 
 * @Date: 2021-12-23 13:40:02 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:54:27
 */
using System;
namespace DISample.ConstructorInjection
{
    internal class ServiceClassA : IServiceClass
    {
        public String ServiceInfo()
        {
            return "我是ConstructorInjection_ServiceClassA";
        }
    }
}