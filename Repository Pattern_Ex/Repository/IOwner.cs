using Repository_Pattern_Ex.Models;

namespace Repository_Pattern_Ex.Repository
{
    public interface IOwner:IRepositoryBase<Owner>
    {
    }
    
    public class OwnerRepository : RepositoryBase<Owner>, IOwner
    { 
        public OwnerRepository(RepositoryContext context):base(context) { }     
    }

}
