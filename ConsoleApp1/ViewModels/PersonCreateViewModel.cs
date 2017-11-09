using System;
using Calabonga.EntityFramework;

namespace CrudOperationsExample.ViewModels
{
    internal class PersonCreateViewModel : IEntityId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}