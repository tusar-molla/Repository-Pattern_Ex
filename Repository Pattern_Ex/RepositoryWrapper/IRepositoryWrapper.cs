using Repository_Pattern_Ex.Models;
using Repository_Pattern_Ex.Repository;

namespace Repository_Pattern_Ex.RepositoryWrapper
{
    public interface IRepositoryWrapper
    {
        IOwner  Owner { get; }
        //IAccount  Account { get; }
        void Save();
    }
    public class RepositoryWrapper : IRepositoryWrapper
    {
       
        private RepositoryContext _repoContext;
        private IOwner  _owner;

        public RepositoryWrapper(RepositoryContext context)
        {
            _repoContext = context;
        }
        public IOwner  Owner
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new OwnerRepository(_repoContext);
                }
                return _owner;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
