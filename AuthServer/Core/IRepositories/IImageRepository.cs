using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepositories
{
    public interface IImageRepository
    {
        Task<Image> AddImageAsync(Image image);
        Task<Image> GetImageByIdAsync(int id);
        Task<Image> DeleteImageAsync(int id);
    }
}
