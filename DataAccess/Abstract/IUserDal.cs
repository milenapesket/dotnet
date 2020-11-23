using System.Collections.Generic;
using Core.Entities.Concrete;
using TokenProject.Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);

    }
}