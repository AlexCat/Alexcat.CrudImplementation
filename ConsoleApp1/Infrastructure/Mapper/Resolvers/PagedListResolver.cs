using System.Collections.Generic;
using Calabonga.PagedListLite;
using CrudOperationsExample.Models;
using CrudOperationsExample.ViewModels;
using ExpressMapper;
using ExpressMapper.Extensions;

namespace CrudOperationsExample.Infrastructure.Mapper.Resolvers
{
    public class PagedListResolver : ICustomTypeMapper<PagedList<Person>, PagedList<PersonViewModel>>
    {
        public PagedList<PersonViewModel> Map(IMappingContext<PagedList<Person>, PagedList<PersonViewModel>> context)
        {
            var items = context.Source.Items.Map<ICollection<Person>, ICollection<PersonViewModel>>();
            return new PagedList<PersonViewModel>(items, context.Source.PageIndex, context.Source.PageSize, context.Source.TotalCount);
        }
    }
}