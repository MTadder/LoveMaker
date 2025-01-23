namespace LoveMaker {
    internal partial class MainForm: Form {
        private static MTLib.Secure.DictionaryFile<String, String> settings = new("settings.mtdb");
        private static MTLib.Secure.Salt secret_salt = new(8);
        public MainForm() {
            this.InitializeComponent();
        }
        private void MainForm_Load(Object sender, EventArgs e) {
            settings.Read();
            if (!settings.HasKey("secret")) {
                settings["secret"] = secret_salt.ToString();
            } else {
                secret_salt = new(settings["secret"]);
            }
        }
        private void MainForm_Closing(Object sender, EventArgs e) {
            settings.Save();
        }

        private void LibraryStore_Click(Object sender, EventArgs e) {
            using LibraryStore store = new();
            _ = store.ShowDialog();
        }
    }
}
