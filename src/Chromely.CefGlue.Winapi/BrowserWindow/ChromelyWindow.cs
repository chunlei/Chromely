using System;
using Chromely.Core;
using Chromely.Core.Host;

namespace Chromely.CefGlue.Winapi.BrowserWindow
{
    public static class ChromelyWindow
    {
        public static IChromelyWindow Create(ChromelyConfiguration config)
        {
            return new CefGlueWindow(config);
        }
    }
}