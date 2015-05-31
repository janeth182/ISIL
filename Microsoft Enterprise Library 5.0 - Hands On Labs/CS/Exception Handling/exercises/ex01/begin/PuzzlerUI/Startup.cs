using System;
using System.Threading;
using System.Windows.Forms;
// TODO: Use Enterpise Library Exception Handling

namespace PuzzlerUI
{
	class Startup
	{
		[STAThread]
		static void Main() 
		{
            // TODO: Handle unhandled exceptions

			Puzzler f = new Puzzler();
			Application.Run(f);
		}
	}
}
