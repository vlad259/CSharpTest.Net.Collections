using System;

namespace System.IO 
{
    #if PLATFORM_ANDROID

    public class ErrorEventArgs : EventArgs
    {

    }

    #endif

    public delegate void ErrorEventHandler (object sender, System.IO.ErrorEventArgs e);
}
