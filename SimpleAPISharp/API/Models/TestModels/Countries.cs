using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace SimpleAPISharp.API.Models.DBModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);

    public class RootObject
{
    public List<Root> roots { get; set; }
}
    public class Ara
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Bre
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class CapitalInfo
    {
        [JsonProperty("latlng")]
        public List<double> Latlng;
    }

    public class Car
    {
        [JsonProperty("signs")]
        public List<string> Signs;

        [JsonProperty("side")]
        public string Side;
    }

    public class Ces
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class CoatOfArms
    {
        [JsonProperty("png")]
        public string Png;

        [JsonProperty("svg")]
        public string Svg;
    }

    public class Currencies
    {
        [JsonProperty("DKK")]
        public DKK DKK;
    }

    public class Cym
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Dan
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Demonyms
    {
        [JsonProperty("eng")]
        public Eng Eng;

        [JsonProperty("fra")]
        public Fra Fra;
    }

    public class Deu
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class DKK
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("symbol")]
        public string Symbol;
    }

    public class Eng
    {
        [JsonProperty("f")]
        public string F;

        [JsonProperty("m")]
        public string M;
    }

    public class Est
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Fin
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Flags
    {
        [JsonProperty("png")]
        public string Png;

        [JsonProperty("svg")]
        public string Svg;

        [JsonProperty("alt")]
        public string Alt;
    }

    public class Fra
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;

        [JsonProperty("f")]
        public string F;

        [JsonProperty("m")]
        public string M;
    }

    public class Gini
    {
        [JsonProperty("2018")]
        public double _2018;
    }

    public class Hrv
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Hun
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Idd
    {
        [JsonProperty("root")]
        public string Root;

        [JsonProperty("suffixes")]
        public List<string> Suffixes;
    }

    public class Ita
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Jpn
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Kor
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Languages
    {
        [JsonProperty("dan")]
        public string Dan;
    }

    public class Maps
    {
        [JsonProperty("googleMaps")]
        public string GoogleMaps;

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMaps;
    }

    public class Name
    {
        [JsonProperty("common")]
        public string Common;

        [JsonProperty("official")]
        public string Official;

        [JsonProperty("nativeName")]
        public NativeName NativeName;
    }

    public class NativeName
    {
        [JsonProperty("dan")]
        public Dan Dan;
    }

    public class Nld
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Per
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Pol
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Por
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class PostalCode
    {
        [JsonProperty("format")]
        public string Format;

        [JsonProperty("regex")]
        public string Regex;
    }

    public class Root
    {
        [JsonProperty("name")]
        public Name Name;

        [JsonProperty("tld")]
        public List<string> Tld;

        [JsonProperty("cca2")]
        public string Cca2;

        [JsonProperty("ccn3")]
        public string Ccn3;

        [JsonProperty("cca3")]
        public string Cca3;

        [JsonProperty("cioc")]
        public string Cioc;

        [JsonProperty("independent")]
        public bool Independent;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("unMember")]
        public bool UnMember;

        [JsonProperty("currencies")]
        public Currencies Currencies;

        [JsonProperty("idd")]
        public Idd Idd;

        [JsonProperty("capital")]
        public List<string> Capital;

        [JsonProperty("altSpellings")]
        public List<string> AltSpellings;

        [JsonProperty("region")]
        public string Region;

        [JsonProperty("subregion")]
        public string Subregion;

        [JsonProperty("languages")]
        public Languages Languages;

        [JsonProperty("translations")]
        public Translations Translations;

        [JsonProperty("latlng")]
        public List<double> Latlng;

        [JsonProperty("landlocked")]
        public bool Landlocked;

        [JsonProperty("borders")]
        public List<string> Borders;

        [JsonProperty("area")]
        public double Area;

        [JsonProperty("demonyms")]
        public Demonyms Demonyms;

        [JsonProperty("flag")]
        public string Flag;

        [JsonProperty("maps")]
        public Maps Maps;

        [JsonProperty("population")]
        public int Population;

        [JsonProperty("gini")]
        public Gini Gini;

        [JsonProperty("fifa")]
        public string Fifa;

        [JsonProperty("car")]
        public Car Car;

        [JsonProperty("timezones")]
        public List<string> Timezones;

        [JsonProperty("continents")]
        public List<string> Continents;

        [JsonProperty("flags")]
        public Flags Flags;

        [JsonProperty("coatOfArms")]
        public CoatOfArms CoatOfArms;

        [JsonProperty("startOfWeek")]
        public string StartOfWeek;

        [JsonProperty("capitalInfo")]
        public CapitalInfo CapitalInfo;

        [JsonProperty("postalCode")]
        public PostalCode PostalCode;
    }

    public class Rus
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Slk
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Spa
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Srp
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Swe
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Translations
    {
        [JsonProperty("ara")]
        public Ara Ara;

        [JsonProperty("bre")]
        public Bre Bre;

        [JsonProperty("ces")]
        public Ces Ces;

        [JsonProperty("cym")]
        public Cym Cym;

        [JsonProperty("deu")]
        public Deu Deu;

        [JsonProperty("est")]
        public Est Est;

        [JsonProperty("fin")]
        public Fin Fin;

        [JsonProperty("fra")]
        public Fra Fra;

        [JsonProperty("hrv")]
        public Hrv Hrv;

        [JsonProperty("hun")]
        public Hun Hun;

        [JsonProperty("ita")]
        public Ita Ita;

        [JsonProperty("jpn")]
        public Jpn Jpn;

        [JsonProperty("kor")]
        public Kor Kor;

        [JsonProperty("nld")]
        public Nld Nld;

        [JsonProperty("per")]
        public Per Per;

        [JsonProperty("pol")]
        public Pol Pol;

        [JsonProperty("por")]
        public Por Por;

        [JsonProperty("rus")]
        public Rus Rus;

        [JsonProperty("slk")]
        public Slk Slk;

        [JsonProperty("spa")]
        public Spa Spa;

        [JsonProperty("srp")]
        public Srp Srp;

        [JsonProperty("swe")]
        public Swe Swe;

        [JsonProperty("tur")]
        public Tur Tur;

        [JsonProperty("urd")]
        public Urd Urd;

        [JsonProperty("zho")]
        public Zho Zho;
    }

    public class Tur
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Urd
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }

    public class Zho
    {
        [JsonProperty("official")]
        public string Official;

        [JsonProperty("common")]
        public string Common;
    }




}
