using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SqlDbContext context) : base(context)
        {
        }

        public User Fing(int id)
        {
            return dbset.Find(id);
            //throw new NotImplementedException();
        }
        public User GetByName(string name)
        {

            return dbset
                .Where(s => s.Name == name)
                .SingleOrDefault();
        }


    }
}
