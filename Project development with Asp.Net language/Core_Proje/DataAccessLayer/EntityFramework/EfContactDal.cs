using System;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal :GenericRepository<Contact>,IContactDal
    {
    }
}
