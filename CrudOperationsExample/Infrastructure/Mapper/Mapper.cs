using Calabonga.EntityFramework;
using Calabonga.PagedListLite;
using CrudOperationsExample.Infrastructure.Mapper.Resolvers;
using CrudOperationsExample.Models;
using CrudOperationsExample.ViewModels;
using ExpressMapper;

namespace CrudOperationsExample.Infrastructure.Mapper
{
    public class Mapper : IMapper
    {
        private IMappingServiceProvider _mapper;

        public Mapper()
        {
            if (_mapper == null)
            {
                _mapper = ExpressMapper.Mapper.Instance;
                RegisterMaps();
            }
                
        }

        public void RegisterMaps()
        {
            _mapper.Register<Person, PersonViewModel>();
            _mapper.RegisterCustom<PagedList<Person>, PagedList<PersonViewModel>, PagedListResolver>();

             
        }

        public TDestionation Map<TSource, TDestionation>(TSource source)
        {
            return _mapper.Map<TSource, TDestionation>(source);
        }

        public void Map<TDestionation, TSource>(TDestionation model, TSource item) where TDestionation : class, IEntityId where TSource : class, IEntityId
        {
            _mapper.Map(typeof(TDestionation), typeof(TSource), model, item);
        }
    }
}