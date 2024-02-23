using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Data.Concrete.Repository
{
    public class EfCoreDocumentRepository : EfCoreGenericRepository<EfCoreDocumentRepository>
    {
        public EfCoreDocumentRepository(DbContext dbContext) : base(dbContext)
        {

        }
        private CaseStudyContext Context
        {
            get { return _dbContext as CaseStudyContext; }
        }
    }
}
