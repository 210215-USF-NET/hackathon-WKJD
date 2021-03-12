using System.Collections.Generic;
using VCVModels;

namespace VCVBL
{
    public interface IImageBL
    {
        Image AddImage(Image newImage);
        List<Image> GetImages();
    }
}