using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IServices
{
    public interface IImageService
    {
        Task<Image> UploadImageAsync(int userId, int challengeId, Stream fileStream, string fileName);
        Task<Image> GetImageByIdAsync(int id);
        Task<Image> DeleteImageAsync(int id);
    }
}
