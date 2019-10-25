using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace TCP_server
{
    class Program
    {
        // it needs to be async and have to be task Return type
        public static async Task Main(string[] args)
        {
            // TODO : you have to change this ip to your own, for this project to work
            IPAddress ip = IPAddress.Parse("169.254.81.58");

            TcpListener serverSocket = new TcpListener(ip, 7000);
            //Alternatively but deprecated
            //TcpListener serverSocket = new TcpListener(6789);

            serverSocket.Start();
            Console.WriteLine("Server started");

            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                //Socket connectionSocket = serverSocket.AcceptSocket();
                Console.WriteLine("Server activated");
                EchoService echoService = new EchoService(connectionSocket);

                // it needs to be await
                await Task.Factory.StartNew(() => echoService.doIt());

                //Thread myThread = await new Thread(echoService.doIt());

                // everything from this line and under, would never be executed
                // since the inside of doIt() have a while(true) in it
            }
            //connectionSocket.Close();
            serverSocket.Stop();

        }
    }
}
