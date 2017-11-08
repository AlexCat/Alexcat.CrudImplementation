using System;
using Calabonga.EntityFramework;

namespace ConsoleApp1
{
    internal class UpdateViewModel : IEntityId
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}