using System.IO;

namespace LoveMaker {
    /// <summary>
    /// Provides static methods for digesting Files/Folders in a LÖVE project
    /// </summary>
    public static class FilesystemLover {
        /// <summary>
        /// Determines if a path is a valid LÖVE game folder.
        /// It searches for a 'main' file in the root of the path.
        /// </summary>
        /// <param name="path">path to determine is valid</param>
        /// <returns>true, if path is a valid LÖVE project root; otherwise, false.</returns>
        public static bool IsValidLoveDirectory(string path) {
            return File.Exists(path + @"\main.moon") || File.Exists(path + @"\main.lua");
        }
    }
}
