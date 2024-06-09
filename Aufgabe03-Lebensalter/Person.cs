using System;
namespace Aufgabe03_Lebensalter
{
	public class Person
	{
		public string name; 
		public int alter;
		
		public Person(string name, int alter)
		{
			this.name = name;
            if (Valid(alter)) this.alter = alter;
            else throw new Exception("Ungültigen Wert, dir Grenze des gültigen Wertes ist 0 bis 120.");
        }

		static bool Valid(int alter)
		{
			if(alter >= 0 && alter <= 120)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

