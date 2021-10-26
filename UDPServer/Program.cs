using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDP server!");

            using (UdpClient socket = new UdpClient())
            {
                socket.Client.Bind(new IPEndPoint(IPAddress.Any, 5005));

                while (true)
                {
                    IPEndPoint clientEndpoint = null;
                    byte[] received = socket.Receive(ref clientEndpoint);
                    Console.WriteLine("Client connected: " + clientEndpoint.Address);
                    Console.WriteLine("Data: " + Encoding.UTF8.GetString(received));
                }
            }
        }
    }
}
