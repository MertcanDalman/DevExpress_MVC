using CaseStudy_Business.Abstract;
using CaseStudy_Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentManager(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public Task CreateAsync(Document document)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Document document)
        {
            await _documentRepository.CreateAsync(document);
        }

        public Task<List<Document>> GetAllDocuments()
        {
            throw new NotImplementedException();
        }

        public Task<Document> GetByIdAsnc(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Document document)
        {
            _documentRepository.Update(document);
        }
    }
}
