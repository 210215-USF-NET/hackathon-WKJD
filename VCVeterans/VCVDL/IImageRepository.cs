﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;
using VCVDL;

namespace VCVDL
{
    public interface IImageRepository
    {

        Image AddImage(Image newImage);

        List<Image> GetImages();




    }
}
