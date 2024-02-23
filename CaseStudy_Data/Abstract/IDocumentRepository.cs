using CaseStudy_Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Data.Abstract
{
    public class IDocumentRepository : IGenericRepository<Document>
    {
        public Task CreateAsync(Document entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(System.Reflection.Metadata.Document document)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Document entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Document>> GetAllDocuments()
        {
            throw new NotImplementedException();
        }

        public Task<Document> GetByIdAsnc(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Document entity)
        {
            throw new NotImplementedException();
        }
    }
}
