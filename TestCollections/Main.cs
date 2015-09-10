using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace TestCollections
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "UnitTestAppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "UnitTestAppDelegate");
		}
	}

	public delegate void ErrorEventHandler (object sender, ErrorEventArgs e);

	public class ErrorEventArgs : EventArgs {

		#region Fields

		Exception exception;

		#endregion // Fields

		#region Constructors

		public ErrorEventArgs (Exception exception) 
		{
			this.exception = exception;
		}

		#endregion // Constructors

		#region Methods

		public virtual Exception GetException ()
		{
			return exception;
		}

		#endregion // Methods
	}
}
