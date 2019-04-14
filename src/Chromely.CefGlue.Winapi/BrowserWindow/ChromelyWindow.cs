using System;
using Chromely.Core;
using Chromely.Core.Host;
using Chromely.Core.Infrastructure;

namespace Chromely.CefGlue.Winapi.BrowserWindow
{
    public static class ChromelyWindow
    {
        public static IChromelyWindow Create(Host type, ChromelyConfiguration config)
        {
            if (type != Host.Winapi)
            {
                string message =
                    $"Application  host type of {type.ToString()} is not supported for this library. Please try a different dll.";
                Log.Error(message);
                throw new Exception(message);
            }

            return new CefGlueWindow(config);
        }
    }
}