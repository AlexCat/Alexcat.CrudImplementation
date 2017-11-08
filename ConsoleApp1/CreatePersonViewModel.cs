using System;
using Calabonga.EntityFramework;

namespace ConsoleApp1
{
    internal class CreatePersonViewModel : IEntityId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}