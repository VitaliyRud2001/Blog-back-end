using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace Blog_back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        private readonly IHostingEnvironment env;
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService,IHostingEnvironment env)
        {
            _imageService = imageService;
            this.env = env;
        }
        [HttpPost]
        public async Task<ActionResult<ImageDto>> SaveImage([FromForm] IFormFile file)
        {
            var uploadedUrl = await _imageService.UploadImageAsync(file);
            return new ImageDto { imageUrl= uploadedUrl,
            fileName=file?.FileName};
        }

        [HttpGet]
        public string Lol()
        {
            return this.env.ContentRootPath;
        }

    }
    public class ImageDto
    {
        public string imageUrl { get; set; }
        public string fileName { get; set; }
    }
}