using System;
using Calabonga.EntityFramework;

namespace ConsoleApp1
{
    public class Logger : IEntityFrameworkLogService
    {
        public void LogInfo(string message)
        {
        }

        public void LogError(Exception exception)
        {
        }
    }
}