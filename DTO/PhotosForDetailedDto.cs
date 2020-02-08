using System;

namespace DateMatchApp.API.DTO
{
    public class PhotosForDetailedDto
    {
        public int id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}