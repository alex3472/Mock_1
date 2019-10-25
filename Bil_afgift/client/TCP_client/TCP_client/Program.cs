using System;
using System.IO;
using System.Net.Sockets;

namespace TCP_client
{
    class Program
    {
        static void Main(string[] args)
        {
            // here we will need to write the ip, of the computer that runs the server (if you run them both on one pc, then it's the same). 
            // use ipconfig to find your own ip address
            // TODO : you have to change this ip to your own, for this project to work
            TcpClient clientSocket = new TcpClient("169.254.81.58", 7000);
            Console.WriteLine("Client ready");

            Stream ns = clientSocket.GetStream();  //provides a Stream
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing
            
            while(true)
            {
                // part 1 - get the car type from the user
                Console.WriteLine("skriv '1' for personbil, skriv '2' for elbil");
                string message = Console.ReadLine();

                // the type of the car | user input
                string carType = "";
                // the price of the car | user input
                double carPrice = 0;

                // part 2 - check if the user input is usable 
                if (message == "1" || message == "2") // if the input is 1 or 2
                {
                    if (message == "1")
                        carType = "per";
                    else
                        carType = "el";
                }
                else  // if the input is anything other than "1" or "2" 
                {
                    Console.WriteLine("ukendt værdi. Vi starter forfra");
                    // restart the loop 
                    continue;
                }

                // part 3 - get the price from the user
                Console.WriteLine("Modtaget");
                Console.WriteLine("Skriv prisen her: | brug ikke koma (,) men kun punktium (.) |");

                message = Console.ReadLine();
                

                // part 4 - check the price from the user
                if (!Double.TryParse(message, out carPrice)) // if the input could not be converted to a double
                {
                    // restart the loop 
                    continue;
                }

                // if the code would fail before this, it would had restarted the loop

                // send the type to the server
                sw.WriteLine(carType);

                // send the price to the server
                // but frist round it to nearest int and convert it to an int
                sw.WriteLine(
                    Convert.ToInt32(
                        Math.Round(carPrice)
                                    )
                    );
                
                // get the answer from the server
                string serverAnswer = sr.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Server: " + serverAnswer);
                Console.WriteLine();
            };

            Console.WriteLine("No more from server. Press Enter");
            Console.ReadLine();

            ns.Close();

            clientSocket.Close();
        }
    }
}
