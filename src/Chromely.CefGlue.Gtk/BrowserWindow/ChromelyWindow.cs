using Chromely.Core;
using System;
using Chromely.Core.Host;

namespace Chromely.CefGlue.Gtk.BrowserWindow
{
    public static class ChromelyWindow
    {
        public static IChromelyWindow Create(ChromelyConfiguration config)
        {
            return new CefGlueWindow(config);
        }
    }
}