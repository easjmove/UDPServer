using System;
using System.Net.Sockets;
using System.Text;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDP Client");
            byte[] data = Encoding.UTF8.GetBytes("hej med jer alle");
            using (UdpClient socket = new UdpClient())
            {
                socket.Send(data, data.Length, "255.255.255.255", 5005);
            }
        }
    }
}
