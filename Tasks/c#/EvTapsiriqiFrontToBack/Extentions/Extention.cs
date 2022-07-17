using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Extentions
{
    public static class Extention
    {
        public static bool IsType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }
        public static bool MaxLenght(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }
        public async static Task<string> SaveImage(this IFormFile file, string root, params string[] paths)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            foreach(string item in paths)
            {
                root = Path.Combine(root, item);
            }
            string resultPash = Path.Combine(root, fileName);
            using (FileStream fileStream = new FileStream(resultPash, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
 
    }
}
