using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VCVModels
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public User User { get; set; }
        [DisplayName("Image")]
        public string ByteStream { get; set; }
    }
}
