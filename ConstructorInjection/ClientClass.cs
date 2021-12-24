/*
 * @Author: yk 
 * @Date: 2021-12-23 13:45:29 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:04:25
 */
using System;
namespace DISample.ConstructorInjection
{
    internal class ClientClass
    {
        private IServiceClass _serviceImple;
        public ClientClass(IServiceClass serviceImple)
        {
            this._serviceImple = serviceImple;
        }
        public void ShowInfo()
        {
            Console.WriteLine(_serviceImple.ServiceInfo());
        }
    }
}