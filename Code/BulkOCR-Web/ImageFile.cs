using Microsoft.AspNetCore.Components.Forms;

namespace BulkOCR_Web
{
    public class ImageFile
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public string ContentType { get; set; }
        public string? FilePath { get; set; }

        //public ImageFile(string Name, long Size, DateTimeOffset LastModified, string ContentType, string Extension, string FilePath = null)
        public ImageFile(IBrowserFile imageFile)
        {
            this.Name = imageFile.Name;
            this.Size = imageFile.Size;
            this.LastModified = imageFile.LastModified;
            this.ContentType = imageFile.ContentType;
            this.Extension = GetExtension(imageFile);
            this.FilePath = null;
        }

        public string GetExtension(IBrowserFile imageFile)
        {
            return Path.GetExtension(imageFile.Name);
        }

    }
}
