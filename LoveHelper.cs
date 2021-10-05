using System;
using System.IO;
using System.Collections.Generic;

namespace LoveMaker {
    public class LoveHelper {
        private static readonly String[] _keyPaths = {
            @"moonscript\", @"Moonscript\",
            @"love\", @"LOVE\",
            @"mingw\bin\", @"MinGW\bin\",
        };

        private static readonly String[] _keyFiles = {
            "moonc.exe", "moon.exe",
            "lovec.exe", "love.exe",
            "luac.exe", "lua.exe",
        };

        private void RemoveDuplicates() {
            String last = String.Empty;
            foreach (String item in this._keys) {
                if (item.Equals(last, StringComparison.OrdinalIgnoreCase)) {
                    _ = this._keys.Remove(item);
                }
            }
        }

        private HashSet<String> _keys;

        public LoveHelper(Boolean autosearch = false) {
            this._keys = new();
            if (autosearch is true) {
                this.Search("C:");
                this.Search(Environment.CurrentDirectory);
                var specialFolders = (Environment.SpecialFolder[]) Enum.GetValues(typeof(Environment.SpecialFolder));
                foreach (var spFolder in specialFolders) {
                    String gotPath = Environment.GetFolderPath(spFolder, Environment.SpecialFolderOption.DoNotVerify);
                    if (gotPath != String.Empty) {
                        this.Search(gotPath);
                    }
                }
            }
        }

        public String GetKeyfile(String key) {
            foreach (String keyFilename in _keyFiles) {
                if (keyFilename.Equals(key)) {
                    var keyExplorer = this._keys.GetEnumerator();
                    while (keyExplorer.MoveNext()) {
                        if (keyExplorer.Current.Contains(keyFilename))
                            return keyExplorer.Current;
                    }
                }
            } return String.Empty;
        }

        public void Search(String path) {
            if (Directory.Exists(path)) {
                foreach (String candidateDirName in _keyPaths) {
                    String candidatePath = path + @"\" + candidateDirName;
                    if (Directory.Exists(candidatePath))
                        foreach (String candidateFilename in _keyFiles) {
                            String candidateFilePath = candidatePath + candidateFilename;
                            if (File.Exists(candidateFilePath))
                                _ = this._keys.Add(candidateFilePath);
                        }
                }
            }
            this.RemoveDuplicates();
        }
    }
}
