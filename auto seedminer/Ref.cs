using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_seedminer {
    public static class Ref {
        public static readonly string ver = "0.1.0";

        public static string dir_working = Environment.CurrentDirectory;

        public static readonly string file_log = dir_working + "\\auto_seedminer_latest.log";

        public static readonly string name_breadcrumb = "\\auto_seedminer_breadcrumb_DO_NOT_DELETE.dat";
        public static readonly string name_3DSBackup = "Nintendo 3DS auto seedminer backup DO NOT DELETE";

        public static readonly string url_usa = "https://storage.googleapis.com/noahc3_hacktools/3ds/auto_seedminer/usa.tsv";
        public static readonly string url_eur = "https://storage.googleapis.com/noahc3_hacktools/3ds/auto_seedminer/eur.tsv";
        public static readonly string url_jpn = "https://storage.googleapis.com/noahc3_hacktools/3ds/auto_seedminer/jpn.tsv";

        public static Dictionary<string, string> downloads = new Dictionary<string, string> {
            { url_usa, dir_working + "\\data\\titles\\usa.tsv" },
            { url_eur, dir_working + "\\data\\titles\\eur.tsv" },
            { url_jpn, dir_working + "\\data\\titles\\jpn.tsv" }
        };
    }
}
