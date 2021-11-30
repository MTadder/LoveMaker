using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace LoveMaker {
    public class LoveHelper {
        public enum FileTypes { EXE, LUA, MOON }
        internal static readonly String[] _keyPaths = {
            @"moonscript\", @"Moonscript\",
            @"mingw\bin\", @"MinGW\bin\"
        };
        internal static readonly String[] _keyCompilers = { "moonc.exe", "luac.exe" };
        internal static readonly String[] _keyLoveFiles = {
            "main.lua", "conf.lua",
            "main.moon", "conf.moon"
        };
        public LoveHelper() {
            
        }
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

        public static List<FileInfo> GetFiles(String inPath, FileTypes fT, Boolean recursive) {
            String extension = fT.ToString().ToLower();
            StringComparison ignoreCase = StringComparison.OrdinalIgnoreCase;
            List<FileInfo> gotFiles = GetFiles(inPath, recursive);
            foreach (FileInfo gotFileInfo in gotFiles) {
                if (gotFileInfo.Extension.Equals(extension, ignoreCase).Equals(false)) {
                    _ = gotFiles.Remove(gotFileInfo);
                }
            } return gotFiles;
        }

        public static Boolean IsValidLOVEDirectory(String path, Boolean strict = false) {
            Boolean mainL = false, confL = false;
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            foreach (String fFullName in Directory.GetFiles(path)) {
                String[] fFullNameSplit = fFullName.Split(".");
                if (fFullNameSplit.Length > 0 && fFullNameSplit.Length - 1 != 0) {
                    String fName = fFullNameSplit[0];
                    String fNameExt = fFullNameSplit[fFullNameSplit.Length - 1];
                    if ("lua".Equals(fNameExt, comp) || "moon".Equals(fName, comp)) {
                        if ("main".Equals(fName, comp)) {
                            mainL = true;
                            if (confL is true) {
                                return true;
                            } else if (strict is false) { return true; }
                        } else if ("conf".Equals(fName, comp)) {
                            confL = true;
                            if (mainL is true) {
                                return true;
                            } else if (strict is false) { return true; }
                        }
                    }
                } else { continue; }
            } return false;
        }
        //public async Task Compile(String rootDir) {
        //    using (Process compilerProc = new()) {
        //        compilerProc.StartInfo.CreateNoWindow = true;
        //        try {
        //            foreach (String keyCompiler in _keyCompilers) {
        //                String cPath = this.GetKeyfile(keyCompiler);
        //                if (File.Exists(cPath)) {
        //                    compilerProc.StartInfo.FileName = cPath;
        //                    foreach (String argFile in this.GetCompilables(rootDir)) {
        //                        String[] argFileExts = argFile.Split(".");
        //                        String argFileExt = argFileExts[argFileExts.Length - 1];
        //                        if (keyCompiler.Contains(argFileExt, StringComparison.OrdinalIgnoreCase)) {
        //                            compilerProc.StartInfo.Arguments += "\"" + argFile + "\" ";
        //                        }
        //                    }
        //                    _ = compilerProc.Start();
        //                    await compilerProc.WaitForExitAsync();
        //                }
        //            } return;
        //        } catch { throw; }
        //    }
        //}
    }
}
