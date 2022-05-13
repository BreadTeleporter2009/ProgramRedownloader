using System;
using System.Net;
using System.IO.Compression;
using System.Threading;
using System.Diagnostics;

namespace Program_Redownloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cwd = Environment.CurrentDirectory;
            Process ExternalProcess = new Process();
            WebClient webClient = new WebClient();
            Console.WriteLine("Welcome to program redownloader!");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            ChangeTermColour.termBGDarkBlue();
            Console.Clear();
            Console.WriteLine("Downloading Google Chrome");
            ConsoleUtility.WriteProgressBar(0);
            webClient.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B33C097EC-6CB9-7808-AEB3-2F4C937C1D32%7D%26lang%3Den-GB%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26brand%3DCHBD%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe", $"{cwd}\\chrome.exe");
            Console.Clear();
            Console.WriteLine("Downloading Visual Studio Code");
            ConsoleUtility.WriteProgressBar(10);
            webClient.DownloadFile("https://az764295.vo.msecnd.net/stable/da15b6fd3ef856477bf6f4fb29ba1b7af717770d/VSCodeUserSetup-x64-1.67.1.exe", $"{cwd}\\vscode.exe");
            Console.Clear();
            Console.WriteLine("Downloading Steam");
            ConsoleUtility.WriteProgressBar(20);
            webClient.DownloadFile("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", $"{cwd}\\steam.exe");
            Console.Clear();
            Console.WriteLine("Downloading 7zip");
            ConsoleUtility.WriteProgressBar(30);
            webClient.DownloadFile("https://www.7-zip.org/a/7z2107-x64.exe", $"{cwd}\\7zip.exe");
            Console.Clear();
            Console.WriteLine("Downloading LibreOffice");
            ConsoleUtility.WriteProgressBar(40);
            webClient.DownloadFile("https://www.libreoffice.org/donate/dl/win-x86_64/7.3.3/en-US/LibreOffice_7.3.3_Win_x64.msi", $"{cwd}\\office.msi");
            Console.Clear();
            Console.WriteLine("Downloading Python");
            ConsoleUtility.WriteProgressBar(50);
            webClient.DownloadFile("https://www.python.org/ftp/python/3.10.4/python-3.10.4-amd64.exe", $"{cwd}\\python.exe");
            Console.Clear();
            Console.WriteLine("Downloading Paint.Net");
            ConsoleUtility.WriteProgressBar(60);
            webClient.DownloadFile("https://www.dotpdn.com/files/paint.net.4.3.10.install.anycpu.web.zip", $"{cwd}\\paint.zip");
            try
            {
                ZipFile.ExtractToDirectory("paint.zip", cwd);
            }
            catch
            { }
            Console.Clear();
            Console.WriteLine("Downloading Shotcut Video Editor");
            ConsoleUtility.WriteProgressBar(70);
            webClient.DownloadFile("https://www.fosshub.com/Shotcut.html?dwl=shotcut-win64-220425.exe", $"{cwd}\\shotcut.exe");
            Console.Clear();
            Console.WriteLine("Finishing Downloads");
            ConsoleUtility.WriteProgressBar(100);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Finished Downloading programs, Do you want to install them as well? (Y/N)");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                open.Programs("chrome.exe");
                open.Programs("vscode.exe");
                open.Programs("steam.exe");
                open.Programs("7zip.exe");
                open.Programs("office.exe");
                open.Programs("python.exe");
                open.Programs("paint.net.4.3.10.install.anycpu.web.exe.exe");
                open.Programs("shotcut.exe");
                Console.WriteLine("Finsihed! Press any key to exit");
                Console.ReadKey();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}