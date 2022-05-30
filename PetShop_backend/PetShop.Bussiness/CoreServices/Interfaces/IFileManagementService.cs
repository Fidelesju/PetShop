using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces
{
    public interface IFileManagementService
    {
       /*  Task<string> StoreFileOnLocal(FileCreateRequestModel file, string folder);
        bool DeleteFile(string filePath);
        bool DeleteFolder(string path);

        string StoreAudioStreamContent(Stream stream, string fileName);

        bool StoreStreamContent(Stream stream, string fileName); */

        public string LogFilePath();
        public string GetBaseUrl();
    }
}