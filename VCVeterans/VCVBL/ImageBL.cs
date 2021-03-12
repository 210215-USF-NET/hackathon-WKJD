using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VCVModels;
using VCVDL;
using System.Threading.Tasks;

namespace VCVBL
{
    public class ImageBL : IImageBL
    {
        private IImageRepository _repo;
        public ImageBL(IImageRepository repo)
        {
            repo = _repo;
        }

        public Image AddImage(Image newImage)
        {
            return _repo.AddImage(newImage);

        }

        public List<Image> GetImages()
        {
            return _repo.GetImages();
        }
    }
}
