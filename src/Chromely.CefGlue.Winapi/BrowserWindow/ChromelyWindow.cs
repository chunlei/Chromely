using Chromely.Core;

namespace Chromely.CefGlue.Winapi.BrowserWindow
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