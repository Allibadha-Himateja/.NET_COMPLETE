using System;
using System.Net.Sockets;

namespace Mynamespace
{
    public class ClientDemo
    {
        public static void Main()
        {
            TcpClient tc =  new TcpClient("192.168.29.114",3050);
        }
    }
}