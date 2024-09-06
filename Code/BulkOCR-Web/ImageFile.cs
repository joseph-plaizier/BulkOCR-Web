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

        public ImageFile(string Name, long Size, DateTimeOffset LastModified, string ContentType, string Extension, string FilePath = null)
        {
            this.Name = Name;
            this.Extension = Extension;
            this.Size = Size;
            this.LastModified = LastModified;
            this.ContentType = ContentType;
            this.FilePath = FilePath;
        }

    }
}
