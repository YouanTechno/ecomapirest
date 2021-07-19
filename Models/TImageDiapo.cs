using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TImageDiapo
    {
        public int ImgId { get; set; }
        public string ImgTitre { get; set; }
        public string ImgDescription { get; set; }
        public byte[] ImgPicture { get; set; }
        public bool? ImgBActif { get; set; }
    }
}
