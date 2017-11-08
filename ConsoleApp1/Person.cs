using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Calabonga.EntityFramework;

namespace ConsoleApp1
{
    public class Person : IEntityId
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}