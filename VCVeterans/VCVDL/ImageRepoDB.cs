using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;

namespace VCVDL
{
    public class ImageRepoDB : IImageRepository
    {

        private readonly VCVDBContext _context;
        public ImageRepoDB(VCVDBContext context)
        {
            _context = context;
        }
        public Image AddImage(Image newImage)
        {
            _context.Images.Add(newImage);
            _context.SaveChanges();
            return newImage;
        }

        public List<Image> GetImages()
        {
            return _context.Images
                 .AsNoTracking()
                 .Select(image => image)
                 .ToList();
        }
    }
}
