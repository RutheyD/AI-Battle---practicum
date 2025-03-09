using Core.IRepositories;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ImageRepository: IImageRepository
    {
        private readonly DataContext _context;
        public ImageRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<Image> AddImageAsync(Image image)
        {
            _context.Images.Add(image);
            await _context.SaveChangesAsync();
            return image;
        }

        public async Task<Image> GetImageByIdAsync(int id)
        {
            return await _context.Images.Include(i => i.User).Include(i => i.Challenge)
                                        .FirstOrDefaultAsync(i => i.ID == id);
        }

        public async Task<Image> DeleteImageAsync(int id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image != null)
            {
                _context.Images.Remove(image);
                await _context.SaveChangesAsync();
            }
            return image;
        }
    }
}
