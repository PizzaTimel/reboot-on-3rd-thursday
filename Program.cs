using System.Diagnostics;
namespace dotnet6
{
    class Program
    {
        static void Main()
        {
            if (Thursday.Checkdate() == true)
            {
                Process.Start("shutdown","/f /r /t 0");
                Environment.Exit(1);                
            }

            Environment.Exit(0);                
        }
        
    }
}
// dotnet publish --runtime win-x64 --configuration Release -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true \bin\Release\net6.0\win-x64\publish