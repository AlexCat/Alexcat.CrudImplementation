using System;
using Calabonga.EntityFramework;

namespace CrudOperationsExample.ViewModels
{
    internal class PersonUpdateViewModel : IEntityId
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}