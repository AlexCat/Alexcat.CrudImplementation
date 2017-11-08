using Calabonga.EntityFramework;
using Calabonga.OperationResults;

namespace ConsoleApp1
{
    internal class PeopleRepostiory : WritableRepositoryBase<Person, UpdateViewModel, CreatePersonViewModel, PagedListQueryParamsBase>
    {
        public PeopleRepostiory(IEntityFrameworkContext context, IEntityFrameworkLogService logger, IMapper mapper) : base(context, logger, mapper)
        {
        }
    }
}