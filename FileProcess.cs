using System;
using System.IO;

namespace UnitTestingProjects
{
    public class FileProcess
    {

        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }
            return File.Exists(fileName);
        }
    }
}
