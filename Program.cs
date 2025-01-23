namespace LoveMaker {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            using MainForm form = new();
            Application.Run(form);
        }
    }
}