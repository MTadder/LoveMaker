using System;
using System.IO;
using System.Windows.Forms;

namespace LoveMaker
{
    /// <summary>
    /// Provides various methods for handling a LÖVE-based project
    /// </summary>
    public class LoveHelper
    {
        public ProgressBar PBStatus;
        private FileSystemWatcher Watcher;
        
        /// <summary>
        /// Acts as a flag for knowing if the Helper has a valid configuration
        /// </summary>
        public bool IsValid = false;

        /// <summary>
        /// Invoked when the project root path is confirmed to be valid
        /// </summary>
        public Action Validated = () => { };
        
        /// <summary>
        /// Invoked when the project root path (and it's validity) is updated
        /// </summary>
        public Action Updated = () => { };
        
        /// <summary>
        /// Invoked when the project root path is confirmed to be invalid
        /// </summary>
        public Action Invalidated = () => { };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void Setup(string path)
        {
            if (FilesystemLover.IsValidLoveDirectory(path))
            {
                this.IsValid = true;
                this.PBStatus.Value += 5;
                this.Watcher = new FileSystemWatcher(path);
                this.Validated.Invoke();
            } else {
                this.IsValid = false;
                this.PBStatus.Value = 0;
                this.Watcher = null;
                this.Invalidated.Invoke();

                string msg = "The selected directory is not a valid LÖVE2D game.\n" +
                    "Missing: '" + (path + @"\") + "main.[lua | moon]'!";
                string title = "Notice";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Updated.Invoke();
        }
    }

    /// <summary>
    /// Provides static methods for digesting Files/Folders in a LÖVE project
    /// </summary>
    public static class FilesystemLover
    {
        /// <summary>
        /// Determines if a path is a valid LÖVE game folder.
        /// It searches for a 'main' file in the root of the path.
        /// </summary>
        /// <param name="path">path to determine is valid</param>
        /// <returns>true, if path is a valid LÖVE project root; otherwise, false.</returns>
        public static bool IsValidLoveDirectory(string path)
        {
            return File.Exists(path + @"\main.moon") || File.Exists(path + @"\main.lua");
        }
    }

    static class MainProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
