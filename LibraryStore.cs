namespace LoveMaker;
internal partial class LibraryStore: Form {
    private List<LibraryExplorer.LuaLibrary> libs = [];
    public LibraryStore() {
        this.InitializeComponent();
    }
    private void AddLibraryToStore(LibraryExplorer.LuaLibrary lib) {
        // Add the library to the store.
        var item = new ListViewItem(lib.Name.Trim()) {
            Tag = lib,
        };
        this.Libraries.Invoke(new Action(() => this.Libraries.Items.Add(item)));
    }

    private async void RefreshAvailableLibraries() {
        // Fetch the libraries from the LibraryExplorer.
        // Display the libraries in the list.
        this.libs = await LibraryExplorer.ScrapeLibrariesAsync().ConfigureAwait(false);
        foreach (var lib in libs) {
            this.AddLibraryToStore(lib);
        }
    }

    private void Cancel_Click(Object sender, EventArgs e) {
        this.Close();
    }

    private void LibraryStore_Load(Object sender, EventArgs e) {
        this.RefreshAvailableLibraries();
        Libraries.ListViewItemSorter = new AlphabeticSorter();
    }
    private class AlphabeticSorter: System.Collections.IComparer {
        public int Compare(object x, object y) {
            // Compare the text of the ListView items
            return String.Compare(((ListViewItem) x).Text, ((ListViewItem) y).Text);
        }
    }

    private void Install_Click(Object sender, EventArgs e) {

    }

    private void Libraries_SelectedIndexChanged(Object sender, EventArgs e) {
        this.Docs.Enabled = Libraries.SelectedItems.Count == 1;
    }

    private void Docs_Click(object sender, EventArgs e) {
        if (Libraries.SelectedItems.Count != 1) { return; }
        if (Libraries.SelectedItems[0] is null) { return; }
        if (Libraries.SelectedItems[0].Tag is null) { return; }
        var lib = (LibraryExplorer.LuaLibrary) Libraries.SelectedItems[0].Tag;
        if (Uri.TryCreate(lib.Link, UriKind.Absolute, out var uriResult) &&
            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps)) {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
                FileName = uriResult.ToString(),
                UseShellExecute = true
            });
        } else {
            MessageBox.Show("The selected library link is not valid.", "Invalid Link!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Refresh_Click(object sender, EventArgs e) {
        this.Libraries.Items.Clear();
        this.RefreshAvailableLibraries();
    }
}
