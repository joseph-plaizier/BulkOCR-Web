using Tesseract;

namespace BulkOCR_Web
{
    public class Tess
    {
        
        
        public string AppStart()
        { 
            var archi = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString();
        if(archi == "X64")
            {
                TesseractEnviornment.CustomSearchPath = "\x64";
            }
        else if(archi == "X86")
            {
                TesseractEnviornment.CustomSearchPath = "\x86";
            }

            return TesseractEnviornment.CustomSearchPath.ToString();
        }
    }
}
