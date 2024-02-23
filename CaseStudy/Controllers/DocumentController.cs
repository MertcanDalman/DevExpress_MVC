using CaseStudy_Business.Abstract;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : Controller
    {
        private readonly IDocumentService _documentManager;

        public DocumentController(IDocumentService documentManager)
        {
            _documentManager = documentManager;
        }
        #region API işlemleri için
        //private readonly HttpClient _apiClient;

        //public DocumentController()
        //{
        //    _apiClient = new HttpClient();
        //    _apiClient.BaseAddress = new Uri("https://example.com/api/"); // API'nin temel adresi girebiliriz.
        //}

        //public async Task<IActionResult> SaveFileAndSendToAPI(Document document)
        //{
        //    try
        //    {
        //        // Dosyayı kaydetme işlemi
        //        string filePath =Server.MapPath("~/App_Data/" + document.Name); // Dosyanın kaydedileceği yol
        //        document.Save(filePath);

        //        // API'ye dosyayı gönderme işlemi
        //        HttpResponseMessage response = await _apiClient.PostAsync("files", new StreamContent(document.)); // API'de dosyaları kabul eden bir endpoint belirtin
        //        response.EnsureSuccessStatusCode(); // Başarılı bir yanıt alınmazsa istisna fırlat

        //        return Content("Dosya başarıyla kaydedildi ve API'ye gönderildi.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content("Dosya kaydedilirken bir hata oluştu: " + ex.Message);
        //    }
        //}

        //public async Task<ActionResult> DeleteFileViaAPI(string fileName)
        //{
        //    try
        //    {
        //        // API'ye dosya silme isteği gönderme işlemi
        //        HttpResponseMessage response = await _apiClient.DeleteAsync("files/" + fileName); // API'de dosyaları silen bir endpoint belirtin
        //        response.EnsureSuccessStatusCode(); // Başarılı bir yanıt alınmazsa istisna fırlat

        //        // Zengin Metin Düzenleyiciyi sıfırlama işlemi
        //        // Örnek olarak:
        //        ViewBag.RichEditContent = ""; // RichEditControl'ün içeriğini temizleyin

        //        return Content("Dosya başarıyla silindi ve Zengin Metin Düzenleyici sıfırlandı.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content("Dosya silinirken bir hata oluştu: " + ex.Message);
        //    }
        //}
        #endregion

        //public async IActionResult SaveDocument(Document document)
        //{
        //    var response = await _documentManager.CreateAsync(document); // Document objesini DTO kullanarak düzenleyebiliriz 
        //    return View(response); 
        //}

    }
}
