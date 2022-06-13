using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace LoveMaker {
    public class LoveHelper {
        internal static List<DirectoryInfo> GetFolders(String inPath) {
            List<DirectoryInfo> gotDirs = new();
            if (Directory.Exists(inPath)) {
                foreach (String dir in Directory.GetDirectories(inPath)) {
                    gotDirs.Add(new DirectoryInfo(dir));
                } return gotDirs;
            } throw new DirectoryNotFoundException($"{inPath} does not exist!");
        }
        internal static List<FileInfo> GetFiles(String inPath, Boolean recursive = false) {
            List<FileInfo> gotFiles = new();
            String targetPath = inPath;
            if (recursive.Equals(true)) {
                foreach (DirectoryInfo inf in GetFolders(targetPath)) {
                    gotFiles.AddRange(GetFiles(inf.FullName));
                }
            } else {
                foreach (String fileName in Directory.GetFiles(inPath)) {
                    gotFiles.Add(new FileInfo(fileName));
                }
            } return gotFiles;
        }
        public static List<FileInfo> GetFiles(String inPath, String? withExtension, Boolean recursive = false) {
            List<FileInfo> files = GetFiles(inPath, recursive);
            if (String.IsNullOrEmpty(withExtension)) { return files; }
            foreach (FileInfo fI in files) {
                if (fI.Extension.Equals(withExtension).Equals(false)) {
                    _ = files.Remove(fI);
                }
            }
            return files;
        }
        public static Boolean HasGit(String path) {
            return Directory.Exists(path + @"\.git");
        }
        public static Boolean HasLove(String path, Boolean strict = false) {
            if (Directory.Exists(path)) {
                List<FileInfo> files = GetFiles(path, strict ? "lua" : null, false);
                if (files.Count != 0) {
                    foreach (FileInfo fI in files) {
                        if (fI.FullName.Contains("main", StringComparison.CurrentCulture)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
