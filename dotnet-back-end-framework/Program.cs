using dotnet_back_end_framework.Network;

namespace dotnet_back_end_framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Http.SendHttpRequest(uri: new Uri("http://rezayari.ir") , 80);

            var server = new Server();

            server.Listen();
        }
    }
}
