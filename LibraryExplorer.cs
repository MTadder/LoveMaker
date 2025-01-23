using System.Text.RegularExpressions;

namespace LoveMaker;
internal static class LibraryExplorer {
    private static readonly string AwesomeLove2DUrl = "https://raw.githubusercontent.com/love2d-community/awesome-love2d/master/README.md";
    internal record class LuaLibrary {
        public String Name { set; get; } = "";
        public String Description { set; get; } = "";
        public String Link { set; get; } = "";
    }
    private static List<LuaLibrary> ParseLibraries(string markdownContent) {
        var regex = new Regex(@"\[([^\]]+)\]\((https?://[^\)]+)\)\s*-\s*(.+)", RegexOptions.Compiled);
        var matches = regex.Matches(markdownContent);

        var libraries = new List<LuaLibrary>();

        foreach (Match match in matches) {
            try {
                libraries.Add(new LuaLibrary {
                    Name = match.Groups[1].Value,
                    Link = match.Groups[2].Value,
                    Description = match.Groups[3].Value
                });
            } catch (Exception ex) {
                MessageBox.Show($"Error parsing library: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        return libraries;
    }
    public static async Task<List<LuaLibrary>> ScrapeLibrariesAsync() {
        string content;
        try {
            // Fetch the raw README content securely
            using HttpClient client = new();
            content = await client.GetStringAsync(new Uri(AwesomeLove2DUrl)).ConfigureAwait(false);
        } catch (Exception ex) {
            MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return [];
        }

        // Parse library information using Regex
        return await Task.Run(() => ParseLibraries(content)).ConfigureAwait(false);
    }
    public static void Fetch(LuaLibrary lib) {
        // Fetch the library from Github.
    }
    internal static class Libraries {
        public static readonly LuaLibrary hump = new() {
            Name = "hump",
            Description = "LÖVE Helper Utilities for Massive Progression",
            Link = "https://github.com/HDictus/hump.git"
        };
        public static readonly LuaLibrary lume = new() {
            Name = "lume",
            Description = "A collection of functions for Lua, geared towards game development.",
            Link = "https://github.com/rxi/lume.git"
        };
        public static readonly LuaLibrary anim8 = new() {
            Name = "anim8",
            Description = "A small library to handle sprite animations.",
            Link = "https://github.com/kikito/anim8.git"
        };

        public static readonly LuaLibrary sti = new() {
            Name = "Simple Tiled Implementation",
            Description = "Tiled map loader and renderer.",
            Link = "https://github.com/karai17/Simple-Tiled-Implementation.git"
        };

        public static readonly LuaLibrary loveframes = new() {
            Name = "LoveFrames",
            Description = "A GUI library for LÖVE.",
            Link = "https://github.com/NikolaiResokav/LoveFrames.git"
        };
    }
}
