using System;
using System.Net.Sockets;

namespace Mynamespace
{
    public class ServerDemo
    {
        public static void Main()
        {
            // this is a Server and Server will do one thing 
            // which is it will wait for request from other system
            // it will listen at partiular ip address and port no

            // in C# we have to create the Server using 
            // TcpListener of System.Net.Sockets;

            TcpListener l = new TcpListener(System.Net.IPAddress.Parse("192.168.29.114"), 3050);
            l.Start();
            while (true)
            {
                if (l.Pending())
                {
                    TcpClient client = l.AcceptTcpClient();
                    //ProcessClient(client);
                    Console.WriteLine("Client Connected");
                }

                // Keep UI responsive while waiting for connections
                //Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }

        }
    }
}