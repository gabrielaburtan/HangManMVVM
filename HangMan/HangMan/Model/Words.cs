using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace HangMan.Model
{
    [Serializable]
    public class Words
    {
        [XmlArray]
        public ObservableCollection<string> Cars { get; set; } = new ObservableCollection<string>();
        [XmlArray]
        public ObservableCollection<string> Movies { get; set; } = new ObservableCollection<string>();
        [XmlArray]
        public ObservableCollection<string> Flowers { get; set; } = new ObservableCollection<string>();
        [XmlArray]
        public ObservableCollection<string> Rivers { get; set; } = new ObservableCollection<string>();

        public Words()
        {
            //Cars.Add("DACIA LOGAN");
            //Cars.Add("BMW");
            //Cars.Add("MERCEDES");
            //Cars.Add("TOYOTA");
            //Cars.Add("HYUNDAI");
            //Cars.Add("RENAULT");
            //Cars.Add("FORD");
            //Cars.Add("VOLKSVAGEN");
            //Cars.Add("HONDA");
            //Cars.Add("SUBARU");
            //Cars.Add("FERRARI");
            //Cars.Add("ASTON MARTIN");
            //Cars.Add("CITROEN");
            //Cars.Add("RANGE ROVER");
            //Cars.Add("LAND ROVER");
            //Cars.Add("OPEL");
            //Cars.Add("AUDI");
            //Cars.Add("PORCHE");

            //Movies.Add("TITANIC");
            //Movies.Add("TRES METROS SOBRE EL CIELO");
            //Movies.Add("HACHIKO");
            //Movies.Add("JOKER");
            //Movies.Add("SUPERMAN");
            //Movies.Add("LA CASA DE PAPEL");
            //Movies.Add("CERNOBIL");
            //Movies.Add("AVENGERS");
            //Movies.Add("FROZEN");
            //Movies.Add("JUMANJI");
            //Movies.Add("RAZBOIUL STELELOR");
            //Movies.Add("PE ARIPILE VANTULUI");
            //Movies.Add("THE LION KING");
            //Movies.Add("LUCIFER");
            //Movies.Add("BATMAN");
            //Movies.Add("SPIDERMAN");
            //Movies.Add("MIRAGE");

            //Flowers.Add("LALEA");
            //Flowers.Add("CRIN");
            //Flowers.Add("TRANDAFIR");
            //Flowers.Add("LACRAMIOARA");
            //Flowers.Add("FLOAREA SOARELUI");
            //Flowers.Add("GERBERA");
            //Flowers.Add("GAROAFA");
            //Flowers.Add("CRIZANTEMA");
            //Flowers.Add("BUJOR");
            //Flowers.Add("FREZIE");
            //Flowers.Add("ZAMBILA");
            //Flowers.Add("NARCISA");
            //Flowers.Add("STANJENEL");
            //Flowers.Add("TOPORAS");
            //Flowers.Add("FLOARE DE COLT");

            //Rivers.Add("DUNARE");
            //Rivers.Add("VOLGA");
            //Rivers.Add("PRUT");
            //Rivers.Add("NIL");
            //Rivers.Add("OLT");
            //Rivers.Add("TIMIS");
            //Rivers.Add("SENA");
            //Rivers.Add("CRISUL ALB");
            //Rivers.Add("CRISUL NEGRU");
            //Rivers.Add("CRISUL REPEDE");
            //Rivers.Add("TAMISA");
            //Rivers.Add("MURES");
            //Rivers.Add("BISTRITA");
            //Rivers.Add("SIRET");
            //Rivers.Add("MISSISSIPPI");
            //Rivers.Add("AMAZON");
            //Rivers.Add("RIN");
            //Rivers.Add("NIAGARA");
        }
    }
}
