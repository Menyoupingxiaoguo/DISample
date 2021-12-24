/*
 * @Author: yk 
 * @Date: 2021-12-23 13:45:29 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 13:59:08
 */
using System;
namespace DISample.SetterInjection
{
    internal class ClientClass
    {
        private IServiceClass _serviceImple;
        public void SetServiceImple(IServiceClass serviceImple)
        {
            this._serviceImple = serviceImple;
        }
        public void ShowInfo()
        {
            Console.WriteLine(_serviceImple.ServiceInfo());
        }
    }
}