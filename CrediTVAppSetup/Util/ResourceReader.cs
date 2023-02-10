using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrediTVAppSetup.Util
{
    public class ResourceReader
    {
        // to read the file as a Stream
        public static Stream? GetResourceStream(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream(resourceName);
        }

        // to save the resource to a file
        public static void CreateFileFromResource(string resourceName, string path, string file)
        {
            Stream? resourceStream = GetResourceStream(resourceName);
            string fileName = Path.Combine(path, file);

            if (resourceStream != null && !File.Exists(fileName))
            {
                using FileStream fileStream = new FileStream(fileName, FileMode.Create);
                for (int i = 0; i < resourceStream.Length; i++)
                    fileStream.WriteByte((byte)resourceStream.ReadByte());
                fileStream.Close();
            }
        }
    }
}
