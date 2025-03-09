using AutoMapper;
using Core.DTOs;
using Core.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AiBattle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        
            private readonly IImageService _imageService;
            private readonly IMapper _mapper;

            public ImageController(IImageService imageService, IMapper mapper)
            {
                _imageService = imageService;
                _mapper = mapper;
            }

            [HttpPost("upload")]
            public async Task<IActionResult> UploadImage(int userId, int challengeId, IFormFile file)
            {
                if (file == null || file.Length == 0)
                    return BadRequest("No file uploaded.");

                using (var stream = file.OpenReadStream())
                {
                    var fileName = $"{userId}_{challengeId}_{Path.GetFileName(file.FileName)}"; // שם ייחודי לתמונה
                    var image = await _imageService.UploadImageAsync(userId, challengeId, stream, fileName);
                    var imageDTO = _mapper.Map<ImageDTO>(image);

                    return Ok(imageDTO);
                }
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetImageById(int id)
            {
                var image = await _imageService.GetImageByIdAsync(id);
                if (image == null)
                    return NotFound();

                var imageDTO = _mapper.Map<ImageDTO>(image);
                return Ok(imageDTO);
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteImage(int id)
            {
                var image = await _imageService.DeleteImageAsync(id);
                if (image == null)
                    return NotFound();

                return NoContent();
            }
        }
    }

