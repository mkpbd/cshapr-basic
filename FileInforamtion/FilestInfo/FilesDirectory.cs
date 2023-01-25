using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInforamtion.FilestInfo
{
    public class FilesDirectory
    {

        public void GetFileInfo()
        {
            //DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;

            //Console.WriteLine(directory);

            var dir = Directory.GetCurrentDirectory();

            Console.WriteLine(dir);
        }

        //public void CreayeDirectorys(string path)
        //{

        //    DirectoryInfo directoryInfo= new DirectoryInfo(Directory.CreateDirectory(path)).Parent.Parent.Parent;
        //}


    }
}
