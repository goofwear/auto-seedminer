using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace auto_seedminer {
    public static class G4l {

        public static string sessionID;

        public static StreamWriter streamLog;

        public static FormInfo frmInfo;

        public static bool allowSDRemoval = false;
        public static DriveInfo sdCard;

        private static bool _safeToExit = false;
        public static bool safeToExit {
            get {
                return _safeToExit;
            }
            set {
                _safeToExit = value;
                if (value) {
                    if (frmInfo.InvokeRequired) frmInfo.Invoke(new Action(() => frmInfo.lblSafeExit.Text = "Safe to Exit Application"));
                    else frmInfo.lblSafeExit.Text = "Safe to Exit Application";
                } else {
                    if (frmInfo.InvokeRequired) frmInfo.Invoke(new Action(() => frmInfo.lblSafeExit.Text = "DO NOT EXIT APPLICATION"));
                    else frmInfo.lblSafeExit.Text = "DO NOT EXIT APPLICATION";
                }
                
            }
        }

        public struct title {
            public string name;
            public string id;
            public string price;
            public string qrcode;
            public string region;

            public static bool operator == (title c1, title c2) {
                return c1.Equals(c2);
            }

            public static bool operator != (title c1, title c2) {
                return !c1.Equals(c2);
            }

            public title(string name, string id, string price, string qrcode, string region) {
                this.name = name;
                this.id = id;
                this.price = price;
                this.qrcode = qrcode;
                this.region = region;
            }
        }

        public static List<title> titles_usa = new List<title>();
        public static List<title> titles_eur = new List<title>();
        public static List<title> titles_jpn = new List<title>();

        public static title selectedTitle;
    }
}
