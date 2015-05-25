using System;
using System.Collections.Generic;

using System.Text;

using AsyncClient;
using AsyncServer;
using System.Threading;

namespace MyUDPClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //AsyncUdpSever.Servermain("192.168.1.103");
            AsyncUdpClient.Init();
            while(true)
            {

                AsyncUdpClient.auc.SendMsg(Console.ReadLine());
            }


        }
    }
}
