using System;
using System.Linq;
using Autofac;
using Calabonga.EntityFramework;
using Calabonga.PagedListLite;
using CrudOperationsExample.Data;
using CrudOperationsExample.Infrastructure.Logger;
using CrudOperationsExample.Infrastructure.Mapper;
using CrudOperationsExample.Repositories;
using CrudOperationsExample.ViewModels;

namespace CrudOperationsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AppDbContext>().As<IEntityFrameworkContext>();
            builder.RegisterType<Mapper>().As<IMapper>();
            builder.RegisterType<Logger>().As<IEntityFrameworkLogService>();
            builder.RegisterType<PeopleRepostiory>().AsSelf();
            var container = builder.Build();

            var repo = container.Resolve<PeopleRepostiory>();
            repo.Add(new PersonCreateViewModel() {Name = "assassasa", Id = Guid.NewGuid()});
            var result = repo.GetPagedResult<PersonViewModel, string>(1, 2, x => x.Name, SortDirection.Descending);

            foreach (var item in result.Result.Items)
                Console.WriteLine(item.Name);

            Console.ReadKey();
        }
    }
}
