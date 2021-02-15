using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_5._14._2_ListeVonObjekten
{
	class Fahrzeug : IEquatable<Fahrzeug>, IComparable<Fahrzeug>
	{
		// Eigenschaften
		private int geschwindigkeit;
		// readonly: Eigenschaft kann nur im Konstruktor geschrieben werden
		private readonly string bezeichnung;

		// Konstruktor
		public Fahrzeug(int g, string b)
		{
			geschwindigkeit = g;
			bezeichnung = b;
		}

		// Methoden
		public void Beschleunigen(int wert) => geschwindigkeit += wert;

		public override string ToString()
		{
			return "Bezeichnung: " + bezeichnung + "\n" +
				"Geschwindigkeit: " + geschwindigkeit;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Fahrzeug);
		}

		public bool Equals(Fahrzeug other)
		{
			return other != null &&
						 geschwindigkeit == other.geschwindigkeit &&
						 bezeichnung == other.bezeichnung;
		}

		public override int GetHashCode()
		{
			int hashCode = -990109093;
			hashCode = hashCode * -1521134295 + geschwindigkeit.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bezeichnung);
			return hashCode;
		}

		// Vergleichsfuntion
		// Gibt an, ob das Objekt "other":
		// - vor (-1) 
		// - an der gleichen Stelle (0)
		// - oder hinter (1) dem aktuellen Objekt steht

		// => Muss implementiert werden, damit Sort() funktioniert
		public int CompareTo(Fahrzeug other)
		{
			return geschwindigkeit.CompareTo(other.geschwindigkeit);
		}
	}
}
