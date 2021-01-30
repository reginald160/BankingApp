using EasyBanking.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace EasyBanking.Utility.CoreHelpers
{
    public static class LogicHelper
    {
        [Obsolete]
        public static IHostingEnvironment Path;
        private static IWebHostEnvironment _hostEnvironment;
        public const string EmpSuffix = "Emp";
        public const string FirstUser = "Employee";
        public const string ColorGrey = "#808080";
        public static ApplicationDbContext context;
        //private readonly ApplicationDbContext _context;
      
        public static string imagepath (IFormFile model)
        {
            var imageupload = new Imageupload(_hostEnvironment);
            var temppath = imageupload.imageurl(model);
            return temppath;
        }
        public static string ImageUpload(IFormFile model, string foldername, string imageUrl, string webRootPath)
        {

            var imageupload = new Imageupload(_hostEnvironment);
          var result =  imageupload.uploadimage(model, foldername, imageUrl, webRootPath);
            return result;
        }

        public static long AccountNumberGenerator()
        {
            var random = new Random(System.DateTime.Now.Millisecond);
            int generatedRandNum = random.Next(1, 505020040);

            var generatedRandNumToString = String.Format("{0:D9}", generatedRandNum);
            const int MaxLength = 8;

            if (generatedRandNumToString.Length > MaxLength)
                generatedRandNumToString = generatedRandNumToString.Substring(1, MaxLength);

            var stringConcat = "5" + generatedRandNumToString + "6";
            long accountNumber = long.Parse(stringConcat);

            return accountNumber;
        }
        public static long GetRandomNumb()
        {
            long randNumber = 0;
            var rand = new Random();
            var bytes = new byte[1];
            rand.NextBytes(bytes);
            for (int i = 1; i <= 9; i++)
            {
                randNumber = +(rand.Next(1, 9) + (DateTime.Now.Ticks / 1000000000000));
            }

            return randNumber;

        }
      
        public static string GetAdminPass()
        {

            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day + 3;
            var dayToString = day < 9 ? "0" + day.ToString() : day.ToString();
            var MonthTostring = day > 9 ? "0" + month.ToString() : month.ToString();
            var Admin = "CoreAdmin" + MonthTostring + dayToString;

            return Admin;
        }



    }

    public interface ISequencenumbe
    {
        string GetNumberSequence(string module);
    }

   
    public class Imageupload
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public Imageupload(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
       
        public string imageurl(IFormFile model)
        {
            var uploadDir = "images";
            var fileName = Path.GetFileNameWithoutExtension(model.FileName);
            var imageUrlpath = "/" + uploadDir + "/" + fileName;
            return imageUrlpath;
        }
       public string uploadimage(IFormFile model, string foldername, string imageUrl, string webRootPath)
        {   
            var uploadDir = "images";
            var fileName = Path.GetFileNameWithoutExtension(model.FileName);
            var extension = Path.GetExtension(model.FileName);
            fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extension;
            var path = Path.Combine(webRootPath, uploadDir, fileName);
             model.CopyToAsync(new FileStream(path, FileMode.Create));
            imageUrl = "/" + uploadDir + "/" + fileName;

            return imageUrl;
        }

       

    }
    public class SequenceNumber : ISequencenumbe
    {
        private readonly ApplicationDbContext _context;
        

        public SequenceNumber (ApplicationDbContext context)
        {
            _context = context;
        }
        public string GetNumberSequence(string module)
        {
            string result = "";
            try
            {
                int counter = 1;


                var numberSequence = _context.NumberSequences
                    .Where(x => x.Module.Equals(module))
                    .FirstOrDefault();

                if (numberSequence == null)
                {
                    numberSequence = new Models.NumberSequence();
                    numberSequence.Module = module;
                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;
                    numberSequence.NumberSequenceName = module;
                    numberSequence.Prefix = module;

                    _context.Add(numberSequence);
                    _context.SaveChanges();
                }
                else
                {
                    counter = numberSequence.LastNumber;

                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;

                    _context.Update(numberSequence);
                    _context.SaveChanges();
                }

                result = numberSequence.Prefix + counter.ToString().PadLeft(3, '0');
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
