using System;
/*Steps to run:
1. docker run -v C:\csit_313:/csit_313 -e DOTNET_CLI_HOME=/tmp --rm -it docker.io/bitnami/dotnet-sdk
2. cd /csit_313/homework_1
3. dotnet build
4. dotnet run


*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
