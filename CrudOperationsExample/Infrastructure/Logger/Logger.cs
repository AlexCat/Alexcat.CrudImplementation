using System;
using Calabonga.EntityFramework;

namespace CrudOperationsExample.Infrastructure.Logger
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