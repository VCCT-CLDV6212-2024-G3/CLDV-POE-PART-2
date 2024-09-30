using CLDV6212POEPART1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CLDV6212POEPART1.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlobService _blobService;
        private readonly TableService _tableService;
        private readonly QueueService _queueService;
        private readonly FileService _fileService;
        private readonly HttpClient _httpClient;

        public HomeController(BlobService blobService, TableService tableService, QueueService queueService, FileService fileService, IHttpClientFactory httpClientFactory)
        {
            _blobService = blobService;
            _tableService = tableService;
            _queueService = queueService;
            _fileService = fileService;
            _httpClient = httpClientFactory.CreateClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file != null)
            {
                using var stream = file.OpenReadStream();
                await _blobService.UploadBlobAsync("product-images", file.FileName, stream);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerProfile(CustomerProfile profile)
        {
            if (ModelState.IsValid)
            {
                await _tableService.AddEntityAsync(profile);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessOrder(string orderId)
        {
            await _queueService.SendMessageAsync("order-processing", $"Processing order {orderId}");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UploadContract(IFormFile file)
        {
            if (file != null)
            {
                using var stream = file.OpenReadStream();
                await _fileService.UploadFileAsync("contracts-logs", file.FileName, stream);
            }
            return RedirectToAction("Index");
        }

        // Azure Function Integration

        [HttpPost]
        public async Task<IActionResult> StoreTableInfo(string tableName, string partitionKey, string rowKey, string data)
        {
            var url = $"https://st10043611.azurewebsites.net/api/StoreTableInfo?tableName={tableName}&partitionKey={partitionKey}&rowKey={rowKey}&data={data}";
            var response = await _httpClient.PostAsync(url, null);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return BadRequest("Failed to store table info.");
        }

        [HttpPost]
        public async Task<IActionResult> UploadBlob(IFormFile file, string containerName, string blobName)
        {
            if (file != null)
            {
                using var content = new StreamContent(file.OpenReadStream());
                var url = $"https://st10043611.azurewebsites.net/api/UploadBlob?containerName={containerName}&blobName={blobName}";
                var response = await _httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return BadRequest("Failed to upload blob.");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessQueueMessage(string queueName, string message)
        {
            var url = $"https://st10043611.azurewebsites.net/api/ProcessQueueMessage?queueName={queueName}&message={message}";
            var response = await _httpClient.PostAsync(url, null);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return BadRequest("Failed to process queue message.");
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file, string shareName, string fileName)
        {
            if (file != null)
            {
                using var content = new StreamContent(file.OpenReadStream());
                var url = $"https://st10043611.azurewebsites.net/api/UploadFile?shareName={shareName}&fileName={fileName}";
                var response = await _httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return BadRequest("Failed to upload file.");
        }
    }
}
