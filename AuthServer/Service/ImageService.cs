using Core.IRepositories;
using Core.IServices;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ImageService: IImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IS3Service _s3Service;

        public ImageService(IImageRepository imageRepository,IS3Service s3Service)
        {
            _imageRepository = imageRepository;  
            _s3Service = s3Service;
        }
        public async Task<Image> UploadImageAsync(int userId, int challengeId, Stream fileStream, string fileName)
        {
            // העלאת התמונה ל-S3
            var imageUrl = await _s3Service.UploadFileAsync(fileStream, fileName);

            // יצירת אובייקט Image
            var image = new Image
            {
                UserId = userId,
                ChallengeId = challengeId,
                ImageURL = imageUrl,
                UploadedAt = DateTime.UtcNow
            };

            // שמירת התמונה בבסיס הנתונים
            return await _imageRepository.AddImageAsync(image);
        }

        public async Task<Image> GetImageByIdAsync(int id)
        {
            return await _imageRepository.GetImageByIdAsync(id);
        }

        public async Task<Image> DeleteImageAsync(int id)
        {
            return await _imageRepository.DeleteImageAsync(id);
        }
    }
}
