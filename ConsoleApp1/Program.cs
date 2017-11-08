using System;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Calabonga.EntityFramework;
using Calabonga.PagedListLite;

namespace ConsoleApp1
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
            repo.Add(new CreatePersonViewModel() {Name = "assassasa", Id = Guid.NewGuid()});
            var result = repo.GetPagedResult<PersonViewModel, string>(1, 2, x => x.Name, SortDirection.Descending);
        }
    }
}
