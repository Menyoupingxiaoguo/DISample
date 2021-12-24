/*
 * @Author: yk 
 * @Date: 2021-12-23 13:45:29 
 * @Last Modified by: yk
 * @Last Modified time: 2021-12-23 14:50:43
 */
using System;
namespace DISample.PropertyInjection
{
    internal class ClientClass
    {
        private IServiceClass _serviceImple;
        public IServiceClass MyServiceImple
        {
            set
            {
                _serviceImple = value;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine(_serviceImple.ServiceInfo());
        }
    }
}