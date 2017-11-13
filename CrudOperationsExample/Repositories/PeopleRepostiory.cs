using Calabonga.EntityFramework;
using Calabonga.OperationResults;
using CrudOperationsExample.Models;
using CrudOperationsExample.ViewModels;

namespace CrudOperationsExample.Repositories
{
    internal class PeopleRepostiory : WritableRepositoryBase<Person, PersonUpdateViewModel, PersonCreateViewModel, PagedListQueryParamsBase>
    {
        public PeopleRepostiory(IEntityFrameworkContext context, IEntityFrameworkLogService logger, IMapper mapper) : base(context, logger, mapper)
        {
        }
    }
}