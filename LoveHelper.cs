using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace LoveMaker {
    public class LoveHelper {
        private static readonly String[] _keyPaths = {
            @"moonscript\", @"Moonscript\",
            @"mingw\bin\", @"MinGW\bin\",
            //@"love\", @"LOVE\"
        };

        private static readonly String[] _keyCompilers = {
            "moonc.exe", "luac.exe", //"lovec.exe"
        };

        private static readonly String[] _keyLoveFiles = {
            "main.lua", "conf.lua",
            "main.moon", "conf.moon"
        };

        private void RemoveDuplicates() {
            String last = String.Empty;
            foreach (String item in this._keys) {
                if (item.Equals(last, StringComparison.OrdinalIgnoreCase)) {
                    _ = this._keys.Remove(item);
                }
            }
        }

        private HashSet<String> GetCompilables(String withinPath) {
            HashSet<String> set = new();

            foreach (String candidateFile in Directory.EnumerateFiles(withinPath)) {
                String[] nameSplit = candidateFile.Split(".");
                try {
                    String fileExt = nameSplit[nameSplit.Length - 1];
                    Debug.Print(fileExt);
                    if (fileExt.Length > 0) {
                        foreach (String compilable in _keyLoveFiles) {
                            if (fileExt.Contains(compilable.Split(".")[1],
                                StringComparison.OrdinalIgnoreCase)) {
                                _ = set.Add(candidateFile);
                            }
                        }
                    }
                } catch (IndexOutOfRangeException) { continue; }
            }

            return set;
        }

        private HashSet<String> _keys;

        public LoveHelper(Boolean autosearch = false) {
            this._keys = new();
            if (autosearch is true) {
                this.Search("C:");
                this.Search(Environment.CurrentDirectory);
                var specialFolders = (Environment.SpecialFolder[]) Enum.GetValues(typeof(Environment.SpecialFolder));
                foreach (var spFolder in specialFolders) {
                    String gotPath = Environment.GetFolderPath(spFolder,Environment.SpecialFolderOption.DoNotVerify);
                    if (gotPath != String.Empty) {
                        this.Search(gotPath);
                    }
                }
            }
        }

        public String GetKeyfile(String key) {
            foreach (String keyFilename in _keyCompilers) {
                if (keyFilename.Equals(key)) {
                    var keyExplorer = this._keys.GetEnumerator();
                    while (keyExplorer.MoveNext()) {
                        if (keyExplorer.Current.Contains(keyFilename, 
                            StringComparison.OrdinalIgnoreCase))
                            return keyExplorer.Current;
                    }
                }
            } return String.Empty;
        }

        public void Search(String path) {
            if (Directory.Exists(path)) {
                foreach (String candidateDirName in _keyPaths) {
                    String candidatePath = path +@"\"+ candidateDirName;
                    if (Directory.Exists(candidatePath))
                        foreach (String candidateFilename in _keyCompilers) {
                            String candidateFilePath = candidatePath + candidateFilename;
                            if (File.Exists(candidateFilePath))
                                _ = this._keys.Add(candidateFilePath);
                        }
                }
            }
            this.RemoveDuplicates();
        }

        public async Task Compile(String rootDir) {
            using (Process compilerProc = new()) {
                compilerProc.StartInfo.CreateNoWindow = true;
                try {
                    foreach (String keyCompiler in _keyCompilers) {
                        String cPath = this.GetKeyfile(keyCompiler);
                        if (File.Exists(cPath)) {
                            compilerProc.StartInfo.FileName = cPath;
                            foreach (String argFile in this.GetCompilables(rootDir)) {
                                String[] argFileExts = argFile.Split(".");
                                String argFileExt = argFileExts[argFileExts.Length - 1];
                                if (keyCompiler.Contains(argFileExt, StringComparison.OrdinalIgnoreCase)) {
                                    compilerProc.StartInfo.Arguments += "\"" + argFile + "\" ";
                                }
                            }
                            _ = compilerProc.Start();
                            await compilerProc.WaitForExitAsync();
                        }
                    }
                    return;
                } catch { throw; }
            }
        }

        public static Boolean IsLoveDirectory(String path) {
            if (Directory.Exists(path)) {
                foreach (String keyLoveFilename in _keyLoveFiles) {
                    if (File.Exists(path +@"\"+ keyLoveFilename)) {
                        return true; // Match any keyLoveFile
                    }
                }
            } return false;
        }
    }
}
