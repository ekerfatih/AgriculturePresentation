using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework {
    public class EfTeamDal : GenericRepository<Team>, ITeamDal {

    }
}