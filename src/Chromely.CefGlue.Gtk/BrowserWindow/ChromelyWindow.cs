using Chromely.Core;

namespace Chromely.CefGlue.Gtk.BrowserWindow
{
    using Chromely.Core.Host;

    public static class ChromelyWindow
    {
        public static IChromelyWindow Create(ChromelyConfiguration config)
        {
            return new CefGlueWindow(config);
        }
    }
}