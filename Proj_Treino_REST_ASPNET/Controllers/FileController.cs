﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proj_Treino_REST_ASPNET.Business;
using Proj_Treino_REST_ASPNET.Data.VO;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Proj_Treino_REST_ASPNET.Controllers
{
    [ApiVersion("1")]
    [Authorize("Bearer")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class FileController : Controller
    {
        private readonly IFileBusiness _fileBusiness;
        public FileController(IFileBusiness fileBusiness)
        {
            _fileBusiness = fileBusiness;
        }

        [HttpGet("downloadFile/{fileName}")]
        public async Task<IActionResult> GetFileAsync(string fileName)
        {
            byte[] buffer = _fileBusiness.GetFile(fileName);
            if (buffer != null)
            {
                HttpContext.Response.ContentType =
                    $"application/{Path.GetExtension(fileName).Replace(".", "")}";
                HttpContext.Response.Headers.Add("content-length", buffer.Length.ToString());
                await HttpContext.Response.Body.WriteAsync(buffer, 0, buffer.Length);
            }
            return new ContentResult();
        }

        [HttpPost("uploadFile")]
        public async Task<IActionResult> UploadOneFile([FromForm] IFormFile file)
        {
            FileDetailVO detail = await _fileBusiness.SaveFileToDisk(file);
            return new OkObjectResult(detail);
        }

        [HttpPost("uploadMultipleFiles")]
        public async Task<IActionResult> UploadManyFiles([FromForm] List<IFormFile> files)
        {
            List<FileDetailVO> details = await _fileBusiness.SaveFilesToDisk(files);
            return new OkObjectResult(details);
        }
    }
}