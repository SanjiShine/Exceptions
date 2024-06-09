using System;
namespace Aufgabe01_MeinFehler
{
	public class MeinFehler: SystemException
	{
		public int Fehlercode { get; set; }

		public MeinFehler(string message, int fehlercode): base(message)
		{
			this.Fehlercode = fehlercode;
		}
	}
}

