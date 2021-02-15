using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_5._14._2_ListeVonObjekten
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Liste zur Aufnahme der Fahrzeuge anlegen
			// List<Fahrzeug> meineListe = new List<Fahrzeug>();	
			var meineListe = new List<Fahrzeug>();

			// Fahrzeug-Objekte erstellen
			Fahrzeug bmw = new Fahrzeug(100, "BMW");
			var polo = new Fahrzeug(80, "Polo");
			var golf = new Fahrzeug(130, "Golf");
			var honda = new Fahrzeug(120, "Honda");

			// Fahrzeuge der Liste hinzufügen
			meineListe.Add(bmw);
			meineListe.Add(polo);
			meineListe.Add(golf);
			meineListe.Add(honda);

			// Elemente der Liste ausgeben
			Console.WriteLine("Die Elemente der Liste:");
			foreach (var fahrzeug in meineListe)
			{
				Console.WriteLine(fahrzeug);
			}

			// Element in der Liste suchen
			Console.WriteLine("Das vorhandene Objekt bmw wird gesucht:");
			Console.WriteLine(meineListe.Contains(bmw));

			// Damit die Eigenschaften verglichen werden, muss die Klasse
			// IEquatable<T> implementieren
			var gesuchtesFahrzeug = new Fahrzeug(100, "BMW");
			Console.WriteLine("Das neu erzeugte Fahrzeug BMW wird gesucht: ");
			Console.WriteLine(meineListe.Contains(gesuchtesFahrzeug));

			// Liste sortieren
			// => Klasse muss IComparable<T> implementieren
			Console.WriteLine("Sortierte Liste:");
			meineListe.Sort();
			foreach (var fahrzeug in meineListe)
			{
				Console.WriteLine(fahrzeug);
			}
		}
	}
}
