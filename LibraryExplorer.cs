namespace LoveMaker;
public static class LibraryExplorer {
    public struct LuaLibrary {
        public String Name;
        public String[] Tags;
        public String StoreGroup;
        public String Description;
        public String DocumentationLink;
        public String GithubLink;
    }
    public static void Fetch(LuaLibrary lib) {
        // Fetch the library from Github.
    }
    public static class Libraries {
        public static readonly LuaLibrary hump = new() {
            Name = "hump",
            StoreGroup = "utilities",
            Description = "LÖVE Helper Utilities for Massive Progression",
            DocumentationLink = "http://hump.readthedocs.org/",
            GithubLink = "https://github.com/HDictus/hump.git"
        };
        public static readonly LuaLibrary lume = new() {
            Name = "lume",
            Description = "A collection of functions for Lua, geared towards game development.",
            StoreGroup = "utilities",
            DocumentationLink = "https://github.com/rxi/lume",
            GithubLink = "https://github.com/rxi/lume.git"
        };
        public static readonly LuaLibrary anim8 = new() {
            Name = "anim8",
            StoreGroup = "animators",
            Description = "A small library to handle sprite animations.",
            DocumentationLink = "https://github.com/kikito/anim8",
            GithubLink = "https://github.com/kikito/anim8.git"
        };

        public static readonly LuaLibrary sti = new() {
            Name = "Simple Tiled Implementation",
            StoreGroup = "loaders",
            Description = "Tiled map loader and renderer.",
            DocumentationLink = "https://github.com/karai17/Simple-Tiled-Implementation",
            GithubLink = "https://github.com/karai17/Simple-Tiled-Implementation.git"
        };

        public static readonly LuaLibrary loveframes = new() {
            Name = "LoveFrames",
            StoreGroup = "guis",
            Description = "A GUI library for LÖVE.",
            DocumentationLink = "https://github.com/NikolaiResokav/LoveFrames",
            GithubLink = "https://github.com/NikolaiResokav/LoveFrames.git"
        };
    }
}
