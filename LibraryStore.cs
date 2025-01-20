namespace LoveMaker;
public partial class LibraryStore: Form {
    public LibraryStore() {
        this.InitializeComponent();
    }
    private void AddLibraryToStore(LibraryExplorer.LuaLibrary lib) {
        // Add the library to the store.
    }

    private void RefreshAvailableLibraries() {
        // Fetch the libraries from the LibraryExplorer.
        // Display the libraries in the list.
    }

    private void Cancel_Click(Object sender, EventArgs e) {
        this.Close();
    }

    private void LibraryStore_Load(Object sender, EventArgs e) {
        this.RefreshAvailableLibraries();
    }

    private void Install_Click(Object sender, EventArgs e) {

    }

    private void Libraries_SelectedIndexChanged(Object sender, EventArgs e) {
        this.Docs.Enabled = Libraries.SelectedItems.Count == 1;
    }
}
