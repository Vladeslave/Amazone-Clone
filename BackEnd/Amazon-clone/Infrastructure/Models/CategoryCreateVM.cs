﻿
namespace Infrastructure.Models.Caterories
{
    public class CategoryCreateVM
    {
        public string Name { get; set; }
        public List<int> OptionsIds { get; set; }
        //public string ImageBase64 { get; set; }
        public int CategoryId { get; set; }
    }
}