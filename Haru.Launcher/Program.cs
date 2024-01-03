using System;
using System.Diagnostics;
using Haru.IO;
using Haru.Shared;

namespace Haru.Launcher
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Haru.Launcher";

            using (var process = GetProcess())
            {
                process.Start();
            }
        }

        private static Process GetProcess()
        {
            var cwd = Environment.CurrentDirectory;
            return new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    Arguments = GetArguments(SharedConsts.AccountId, SharedConsts.HttpAddress),
                    FileName = VFS.CombinePath(cwd, "EscapeFromTarkov.exe"),
                    WorkingDirectory = cwd
                }
            };
        }

        private static string GetArguments(string accountId, string address)
        {
            var token = "-token=" + accountId;
            var config = "-config={\"BackendUrl\":\"" + address + "\",\"Version\":\"live\"}";
            return $"{token} {config}";
        }
    }
}