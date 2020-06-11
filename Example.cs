using Proxy_Client_Tinsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TinsoftProxy_Example
{
    class Program
    {
        static TinsoftProxy myProxy;
        static void Main(string[] args)
        {

            if (myProxy == null)
            {
                myProxy = new TinsoftProxy("");
            }
            myProxy.api_key = "TLXXXoXXXXX"; //input api key
            myProxy.location = 0; //input location (0 for random)
            string proxy = "";
            string ip = "";
            int port = 0;
            while (true)
            {
                if (myProxy.changeProxy())
                {
                    proxy = myProxy.proxy;
                    ip = myProxy.ip;
                    port = myProxy.port;
                    break;

                }
                else
                {
                    string errorCode = myProxy.errorCode;
                    Console.WriteLine(errorCode);
                }
                Thread.Sleep(10000);
            }
            Console.WriteLine("Get proxy success:"+ proxy);

        }
    }
}
