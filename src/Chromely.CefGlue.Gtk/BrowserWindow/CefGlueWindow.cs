﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GtkCefGlueBrowserWindow.cs" company="Chromely Projects">
//   Copyright (c) 2017-2018 Chromely Projects
// </copyright>
// <license>
// See the LICENSE.md file in the project root for more information.
// </license>
// --------------------------------------------------------------------------------------------------------------------

using Chromely.CefGlue.BrowserWindow;
using Chromely.Core;
using Xilium.CefGlue;

namespace Chromely.CefGlue.Gtk.BrowserWindow
{
    /// <summary>
    /// The CefGlue browser host/window/app.
    /// </summary>
    public class CefGlueWindow : HostBase
    {
        private IWindow mMaWindow;

        /// <summary>
        /// Initializes a new instance of the <see cref="CefGlueWindow"/> class.
        /// </summary>
        /// <param name="hostConfig">
        /// The host config.
        /// </param>
        public CefGlueWindow(ChromelyConfiguration hostConfig) 
            : base(hostConfig)
        {
        }

        /// <summary>
        /// The close.
        /// </summary>
        public new void Close()
        {
            mMaWindow?.Exit();
        }

        /// <summary>
        /// The exit.
        /// </summary>
        public new void Exit()
        {
            mMaWindow?.Exit();
        }

        /// <summary>
        /// The platform initialize.
        /// </summary>
        protected override void Initialize()
        {
            NativeMethods.InitWindow(0, null);
        }

        /// <summary>
        /// The platform run message loop.
        /// </summary>
        protected override void RunMessageLoop()
        {
            if (CefRuntime.Platform == CefRuntimePlatform.Windows)
            {
                /* run the GTK+ main loop */
                NativeMethods.Run();
            }
            else
            {
                CefRuntime.RunMessageLoop();
            }
        }

        /// <summary>
        /// The platform quit message loop.
        /// </summary>
        protected override void QuitMessageLoop()
        {
            if (CefRuntime.Platform == CefRuntimePlatform.Windows)
            {
                NativeMethods.Quit();
            }
            else
            {
                CefRuntime.QuitMessageLoop();
            }
        }

        /// <summary>
        /// The create main view.
        /// </summary>
        /// <returns>
        /// The <see cref="GtkWindow"/>.
        /// </returns>
        protected override IWindow CreateMainView()
        {
            mMaWindow =  new Window(this, HostConfig);
            return mMaWindow;
        }
    }
}
