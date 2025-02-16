﻿//============================================================================
// BDInfo - Blu-ray Video and Audio Analysis Tool
// Copyright © 2010 Cinema Squid
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//=============================================================================

namespace BDCommon
{
  public abstract class LanguageCodes
  {
    public static string GetName(string code)
    {
      switch (code)
      {
        case "abk": return "Abkhazian";
        case "ace": return "Achinese";
        case "ach": return "Acoli";
        case "ada": return "Adangme";
        case "aar": return "Afar";
        case "afh": return "Afrihili";
        case "afr": return "Afrikaans";
        case "afa": return "Afro-Asiatic (Other)";
        case "aka": return "Akan";
        case "akk": return "Akkadian";
        case "alb": return "Albanian";
        case "sqi": return "Albanian";
        case "ale": return "Aleut";
        case "alg": return "Algonquian languages";
        case "tut": return "Altaic (Other)";
        case "amh": return "Amharic";
        case "apa": return "Apache languages";
        case "ara": return "Arabic";
        case "arc": return "Aramaic";
        case "arp": return "Arapaho";
        case "arn": return "Araucanian";
        case "arw": return "Arawak";
        case "arm": return "Armenian";
        case "hye": return "Armenian";
        case "art": return "Artificial (Other)";
        case "asm": return "Assamese";
        case "ath": return "Athapascan languages";
        case "aus": return "Australian languages";
        case "map": return "Austronesian (Other)";
        case "ava": return "Avaric";
        case "ave": return "Avestan";
        case "awa": return "Awadhi";
        case "aym": return "Aymara";
        case "aze": return "Azerbaijani";
        case "ban": return "Balinese";
        case "bat": return "Baltic (Other)";
        case "bal": return "Baluchi";
        case "bam": return "Bambara";
        case "bai": return "Bamileke languages";
        case "bad": return "Banda";
        case "bnt": return "Bantu (Other)";
        case "bas": return "Basa";
        case "bak": return "Bashkir";
        case "baq": return "Basque";
        case "eus": return "Basque";
        case "btk": return "Batak (Indonesia)";
        case "bej": return "Beja";
        case "bel": return "Belarusian";
        case "bem": return "Bemba";
        case "ben": return "Bengali";
        case "ber": return "Berber (Other)";
        case "bho": return "Bhojpuri";
        case "bih": return "Bihari";
        case "bik": return "Bikol";
        case "bin": return "Bini";
        case "bis": return "Bislama";
        case "bos": return "Bosnian";
        case "bra": return "Braj";
        case "bre": return "Breton";
        case "bug": return "Buginese";
        case "bul": return "Bulgarian";
        case "bua": return "Buriat";
        case "bur": return "Burmese";
        case "mya": return "Burmese";
        case "cad": return "Caddo";
        case "car": return "Carib";
        case "cat": return "Catalan";
        case "cau": return "Caucasian (Other)";
        case "ceb": return "Cebuano";
        case "cel": return "Celtic (Other)";
        case "cai": return "Central American Indian (Other)";
        case "chg": return "Chagatai";
        case "cmc": return "Chamic languages";
        case "cha": return "Chamorro";
        case "che": return "Chechen";
        case "chr": return "Cherokee";
        case "chy": return "Cheyenne";
        case "chb": return "Chibcha";
        case "chi": return "Chinese";
        case "zho": return "Chinese";
        case "chn": return "Chinook jargon";
        case "chp": return "Chipewyan";
        case "cho": return "Choctaw";
        case "chu": return "Church Slavic";
        case "chk": return "Chuukese";
        case "chv": return "Chuvash";
        case "cop": return "Coptic";
        case "cor": return "Cornish";
        case "cos": return "Corsican";
        case "cre": return "Cree";
        case "mus": return "Creek";
        case "crp": return "Creoles and pidgins (Other)";
        case "cpe": return "Creoles and pidgins,";
        case "cpf": return "Creoles and pidgins,";
        case "cpp": return "Creoles and pidgins,";
        case "scr": return "Croatian";
        case "hrv": return "Croatian";
        case "cus": return "Cushitic (Other)";
        case "cze": return "Czech";
        case "ces": return "Czech";
        case "dak": return "Dakota";
        case "dan": return "Danish";
        case "day": return "Dayak";
        case "del": return "Delaware";
        case "din": return "Dinka";
        case "div": return "Divehi";
        case "doi": return "Dogri";
        case "dgr": return "Dogrib";
        case "dra": return "Dravidian (Other)";
        case "dua": return "Duala";
        case "dut": return "Dutch";
        case "nld": return "Dutch";
        case "dum": return "Dutch, Middle (ca. 1050-1350)";
        case "dyu": return "Dyula";
        case "dzo": return "Dzongkha";
        case "efi": return "Efik";
        case "egy": return "Egyptian (Ancient)";
        case "eka": return "Ekajuk";
        case "elx": return "Elamite";
        case "eng": return "English";
        case "enm": return "English, Middle (1100-1500)";
        case "ang": return "English, Old (ca.450-1100)";
        case "epo": return "Esperanto";
        case "est": return "Estonian";
        case "ewe": return "Ewe";
        case "ewo": return "Ewondo";
        case "fan": return "Fang";
        case "fat": return "Fanti";
        case "fao": return "Faroese";
        case "fij": return "Fijian";
        case "fin": return "Finnish";
        case "fiu": return "Finno-Ugrian (Other)";
        case "fon": return "Fon";
        case "fre": return "French";
        case "fra": return "French";
        case "frm": return "French, Middle (ca.1400-1600)";
        case "fro": return "French, Old (842-ca.1400)";
        case "fry": return "Frisian";
        case "fur": return "Friulian";
        case "ful": return "Fulah";
        case "gaa": return "Ga";
        case "glg": return "Gallegan";
        case "lug": return "Ganda";
        case "gay": return "Gayo";
        case "gba": return "Gbaya";
        case "gez": return "Geez";
        case "geo": return "Georgian";
        case "kat": return "Georgian";
        case "ger": return "German";
        case "deu": return "German";
        case "nds": return "Saxon";
        case "gmh": return "German, Middle High (ca.1050-1500)";
        case "goh": return "German, Old High (ca.750-1050)";
        case "gem": return "Germanic (Other)";
        case "gil": return "Gilbertese";
        case "gon": return "Gondi";
        case "gor": return "Gorontalo";
        case "got": return "Gothic";
        case "grb": return "Grebo";
        case "grc": return "Greek, Ancient (to 1453)";
        case "gre": return "Greek";
        case "ell": return "Greek";
        case "grn": return "Guarani";
        case "guj": return "Gujarati";
        case "gwi": return "Gwich´in";
        case "hai": return "Haida";
        case "hau": return "Hausa";
        case "haw": return "Hawaiian";
        case "heb": return "Hebrew";
        case "her": return "Herero";
        case "hil": return "Hiligaynon";
        case "him": return "Himachali";
        case "hin": return "Hindi";
        case "hmo": return "Hiri Motu";
        case "hit": return "Hittite";
        case "hmn": return "Hmong";
        case "hun": return "Hungarian";
        case "hup": return "Hupa";
        case "iba": return "Iban";
        case "ice": return "Icelandic";
        case "isl": return "Icelandic";
        case "ibo": return "Igbo";
        case "ijo": return "Ijo";
        case "ilo": return "Iloko";
        case "inc": return "Indic (Other)";
        case "ine": return "Indo-European (Other)";
        case "ind": return "Indonesian";
        case "ina": return "Interlingua (International";
        case "ile": return "Interlingue";
        case "iku": return "Inuktitut";
        case "ipk": return "Inupiaq";
        case "ira": return "Iranian (Other)";
        case "gle": return "Irish";
        case "mga": return "Irish, Middle (900-1200)";
        case "sga": return "Irish, Old (to 900)";
        case "iro": return "Iroquoian languages";
        case "ita": return "Italian";
        case "jpn": return "Japanese";
        case "jav": return "Javanese";
        case "jrb": return "Judeo-Arabic";
        case "jpr": return "Judeo-Persian";
        case "kab": return "Kabyle";
        case "kac": return "Kachin";
        case "kal": return "Kalaallisut";
        case "kam": return "Kamba";
        case "kan": return "Kannada";
        case "kau": return "Kanuri";
        case "kaa": return "Kara-Kalpak";
        case "kar": return "Karen";
        case "kas": return "Kashmiri";
        case "kaw": return "Kawi";
        case "kaz": return "Kazakh";
        case "kha": return "Khasi";
        case "khm": return "Khmer";
        case "khi": return "Khoisan (Other)";
        case "kho": return "Khotanese";
        case "kik": return "Kikuyu";
        case "kmb": return "Kimbundu";
        case "kin": return "Kinyarwanda";
        case "kir": return "Kirghiz";
        case "kom": return "Komi";
        case "kon": return "Kongo";
        case "kok": return "Konkani";
        case "kor": return "Korean";
        case "kos": return "Kosraean";
        case "kpe": return "Kpelle";
        case "kro": return "Kru";
        case "kua": return "Kuanyama";
        case "kum": return "Kumyk";
        case "kur": return "Kurdish";
        case "kru": return "Kurukh";
        case "kut": return "Kutenai";
        case "lad": return "Ladino";
        case "lah": return "Lahnda";
        case "lam": return "Lamba";
        case "lao": return "Lao";
        case "lat": return "Latin";
        case "lav": return "Latvian";
        case "ltz": return "Letzeburgesch";
        case "lez": return "Lezghian";
        case "lin": return "Lingala";
        case "lit": return "Lithuanian";
        case "loz": return "Lozi";
        case "lub": return "Luba-Katanga";
        case "lua": return "Luba-Lulua";
        case "lui": return "Luiseno";
        case "lun": return "Lunda";
        case "luo": return "Luo (Kenya and Tanzania)";
        case "lus": return "Lushai";
        case "mac": return "Macedonian";
        case "mkd": return "Macedonian";
        case "mad": return "Madurese";
        case "mag": return "Magahi";
        case "mai": return "Maithili";
        case "mak": return "Makasar";
        case "mlg": return "Malagasy";
        case "may": return "Malay";
        case "msa": return "Malay";
        case "mal": return "Malayalam";
        case "mlt": return "Maltese";
        case "mnc": return "Manchu";
        case "mdr": return "Mandar";
        case "man": return "Mandingo";
        case "mni": return "Manipuri";
        case "mno": return "Manobo languages";
        case "glv": return "Manx";
        case "mao": return "Maori";
        case "mri": return "Maori";
        case "mar": return "Marathi";
        case "chm": return "Mari";
        case "mah": return "Marshall";
        case "mwr": return "Marwari";
        case "mas": return "Masai";
        case "myn": return "Mayan languages";
        case "men": return "Mende";
        case "mic": return "Micmac";
        case "min": return "Minangkabau";
        case "mis": return "Miscellaneous languages";
        case "moh": return "Mohawk";
        case "mol": return "Moldavian";
        case "mkh": return "Mon-Khmer (Other)";
        case "lol": return "Mongo";
        case "mon": return "Mongolian";
        case "mos": return "Mossi";
        case "mul": return "Multiple languages";
        case "mun": return "Munda languages";
        case "nah": return "Nahuatl";
        case "nau": return "Nauru";
        case "nav": return "Navajo";
        case "nde": return "Ndebele, North";
        case "nbl": return "Ndebele, South";
        case "ndo": return "Ndonga";
        case "nep": return "Nepali";
        case "new": return "Newari";
        case "nia": return "Nias";
        case "nic": return "Niger-Kordofanian (Other)";
        case "ssa": return "Nilo-Saharan (Other)";
        case "niu": return "Niuean";
        case "non": return "Norse, Old";
        case "nai": return "North American Indian (Other)";
        case "sme": return "Northern Sami";
        case "nor": return "Norwegian";
        case "nob": return "Norwegian Bokmål";
        case "nno": return "Norwegian Nynorsk";
        case "nub": return "Nubian languages";
        case "nym": return "Nyamwezi";
        case "nya": return "Nyanja";
        case "nyn": return "Nyankole";
        case "nyo": return "Nyoro";
        case "nzi": return "Nzima";
        case "oci": return "Occitan";
        case "oji": return "Ojibwa";
        case "ori": return "Oriya";
        case "orm": return "Oromo";
        case "osa": return "Osage";
        case "oss": return "Ossetian";
        case "oto": return "Otomian languages";
        case "pal": return "Pahlavi";
        case "pau": return "Palauan";
        case "pli": return "Pali";
        case "pam": return "Pampanga";
        case "pag": return "Pangasinan";
        case "pan": return "Panjabi";
        case "pap": return "Papiamento";
        case "paa": return "Papuan (Other)";
        case "per": return "Persian";
        case "fas": return "Persian";
        case "peo": return "Persian, Old (ca.600-400 B.C.)";
        case "phi": return "Philippine (Other)";
        case "phn": return "Phoenician";
        case "pon": return "Pohnpeian";
        case "pol": return "Polish";
        case "por": return "Portuguese";
        case "pra": return "Prakrit languages";
        case "pro": return "Provençal";
        case "pus": return "Pushto";
        case "que": return "Quechua";
        case "roh": return "Raeto-Romance";
        case "raj": return "Rajasthani";
        case "rap": return "Rapanui";
        case "rar": return "Rarotongan";
        case "roa": return "Romance (Other)";
        case "rum": return "Romanian";
        case "ron": return "Romanian";
        case "rom": return "Romany";
        case "run": return "Rundi";
        case "rus": return "Russian";
        case "sal": return "Salishan languages";
        case "sam": return "Samaritan Aramaic";
        case "smi": return "Sami languages (Other)";
        case "smo": return "Samoan";
        case "sad": return "Sandawe";
        case "sag": return "Sango";
        case "san": return "Sanskrit";
        case "sat": return "Santali";
        case "srd": return "Sardinian";
        case "sas": return "Sasak";
        case "sco": return "Scots";
        case "gla": return "Gaelic";
        case "sel": return "Selkup";
        case "sem": return "Semitic (Other)";
        case "scc": return "Serbian";
        case "srp": return "Serbian";
        case "srr": return "Serer";
        case "shn": return "Shan";
        case "sna": return "Shona";
        case "sid": return "Sidamo";
        case "sgn": return "Sign languages";
        case "bla": return "Siksika";
        case "snd": return "Sindhi";
        case "sin": return "Sinhalese";
        case "sit": return "Sino-Tibetan (Other)";
        case "sio": return "Siouan languages";
        case "den": return "Slave (Athapascan)";
        case "sla": return "Slavic (Other)";
        case "slo": return "Slovak";
        case "slk": return "Slovak";
        case "slv": return "Slovenian";
        case "sog": return "Sogdian";
        case "som": return "Somali";
        case "son": return "Songhai";
        case "snk": return "Soninke";
        case "wen": return "Sorbian languages";
        case "nso": return "Sotho, Northern";
        case "sot": return "Sotho, Southern";
        case "sai": return "South American Indian (Other)";
        case "spa": return "Spanish";
        case "suk": return "Sukuma";
        case "sux": return "Sumerian";
        case "sun": return "Sundanese";
        case "sus": return "Susu";
        case "swa": return "Swahili";
        case "ssw": return "Swati";
        case "swe": return "Swedish";
        case "syr": return "Syriac";
        case "tgl": return "Tagalog";
        case "tah": return "Tahitian";
        case "tai": return "Tai (Other)";
        case "tgk": return "Tajik";
        case "tmh": return "Tamashek";
        case "tam": return "Tamil";
        case "tat": return "Tatar";
        case "tel": return "Telugu";
        case "ter": return "Tereno";
        case "tet": return "Tetum";
        case "tha": return "Thai";
        case "tib": return "Tibetan";
        case "bod": return "Tibetan";
        case "tig": return "Tigre";
        case "tir": return "Tigrinya";
        case "tem": return "Timne";
        case "tiv": return "Tiv";
        case "tli": return "Tlingit";
        case "tpi": return "Tok Pisin";
        case "tkl": return "Tokelau";
        case "tog": return "Tonga (Nyasa)";
        case "ton": return "Tonga (Tonga Islands)";
        case "tsi": return "Tsimshian";
        case "tso": return "Tsonga";
        case "tsn": return "Tswana";
        case "tum": return "Tumbuka";
        case "tur": return "Turkish";
        case "ota": return "Turkish, Ottoman (1500-1928)";
        case "tuk": return "Turkmen";
        case "tvl": return "Tuvalu";
        case "tyv": return "Tuvinian";
        case "twi": return "Twi";
        case "uga": return "Ugaritic";
        case "uig": return "Uighur";
        case "ukr": return "Ukrainian";
        case "umb": return "Umbundu";
        case "und": return "Undetermined";
        case "urd": return "Urdu";
        case "uzb": return "Uzbek";
        case "vai": return "Vai";
        case "ven": return "Venda";
        case "vie": return "Vietnamese";
        case "vol": return "Volapük";
        case "vot": return "Votic";
        case "wak": return "Wakashan languages";
        case "wal": return "Walamo";
        case "war": return "Waray";
        case "was": return "Washo";
        case "wel": return "Welsh";
        case "cym": return "Welsh";
        case "wol": return "Wolof";
        case "xho": return "Xhosa";
        case "sah": return "Yakut";
        case "yao": return "Yao";
        case "yap": return "Yapese";
        case "yid": return "Yiddish";
        case "yor": return "Yoruba";
        case "ypk": return "Yupik languages";
        case "znd": return "Zande";
        case "zap": return "Zapotec";
        case "zen": return "Zenaga";
        case "zha": return "Zhuang";
        case "zul": return "Zulu";
        case "zun": return "Zuni";

        default: return code;
      }
    }
  }
}
