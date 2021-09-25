using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoveMaker {
    public class LoveHelper {
        public struct CallbackBank {
            public Action Update;
            public Action PreExecute;
            public Action PostExecute;
        };

        // public (Action Update, Action Pre, Action Post) Callbacks;

        public struct FlagBank {
            public String ProjectPath;
            public String LuaPath;
            public String MoonPath;
            public Boolean IsValid;
            public ProgressBar PBStatus;
            // public Dictionary<String, String> Variables;
        }

        public CallbackBank Callbacks;
        public FlagBank Flags;

        private Dictionary<String, Dictionary<Action, Boolean>> Registry = new();
        public void Register(String stepName, Action operation) {
            if (this.Registry.ContainsKey(stepName)) {
                this.Registry[stepName].Add(operation, false);
            } else {
                Dictionary<Action, Boolean> reg = new();
                (reg[operation], this.Registry[stepName])
                    = (false, reg);
            }
        }

        [Obsolete("Use Register to query a registry setup")]
        public void Setup(String path) {
            if (FilesystemLover.IsValidLoveDirectory(path)) {
                (this.Flags.ProjectPath, this.Flags.IsValid)
                    = (path, true);
                this.Flags.PBStatus.Value += 5;
            } else {
                (this.Flags.IsValid, this.Flags.PBStatus.Value)
                    = (false, 0);

                String msg = "The selected directory is not a valid LÖVE2D game.\n" +
                    "Missing: '" + path + @"\" + "main.[lua | moon]'!";
                String title = "Notice";
                _= MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Callbacks.Update.Invoke();
        }
    }
}
