using System;
using System.IO;
using System.Linq;
using RS.Extensions;

namespace RS.Web
{
    /// <summary>
    /// This class is used to find root path of the web project in;
    /// unit tests (to find views) and entity framework core command line commands (to find conn string).
    /// </summary>
    public static class WebContentDirectoryFinder
    {
        public static string CalculateContentRootFolder(params string[] projectNames)
        {
            var coreAssemblyDirectoryPath = Path.GetDirectoryName(typeof(WebContentDirectoryFinder).GetAssembly().Location);
            if (coreAssemblyDirectoryPath == null)
            {
                throw new Exception($"Could not find location of {typeof(WebContentDirectoryFinder).Assembly.FullName} assembly!");
            }

            var directoryInfo = new DirectoryInfo(coreAssemblyDirectoryPath);
            while (!DirectoryContains(directoryInfo.FullName, "RS.AbpQuick.sln"))
            {
                directoryInfo = directoryInfo.Parent ?? throw new Exception("Could not find content root folder!");
            }

            if (projectNames != null)
            {
                foreach (var name in projectNames)
                {
                    var webMvcFolder = Path.Combine(directoryInfo.FullName, "src", name);
                    if (Directory.Exists(webMvcFolder))
                    {
                        return webMvcFolder;
                    }
                }
            }

            throw new Exception("Could not find root folder of the web project!");
        }

        private static bool DirectoryContains(string directory, string fileName)
        {
            return Directory.GetFiles(directory).Any(filePath => string.Equals(Path.GetFileName(filePath), fileName));
        }
    }
}
