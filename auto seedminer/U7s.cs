using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Net;
using System.Net.Http;
using Dolinay;
using System.Threading;

namespace auto_seedminer {
    class U7s {

        private static WebClient web = new WebClient();
        private static HttpClient http = new HttpClient();

        private static DriveDetector driveDetector;

        private static bool waitingForSDCard = false;

        //stuff sent through this method displays information to the user AND logs it to file
        public static void info(string message) {
            if (G4l.frmInfo.InvokeRequired) G4l.frmInfo.Invoke(new Action(() => G4l.frmInfo.lblInfo.Text = message));
            else G4l.frmInfo.lblInfo.Text = message;
            G4l.streamLog.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + message);
        }

        //stuff sent through this method only logs to file
        public static void log(string message) {
            G4l.streamLog.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + message);
        }

        public static void DownloadFile(string url, string output) {
            info("Downloading file " + output.Split('\\').Last() + " to directory " + output);
            FileSystem.CreateDirectory(output.Substring(0, output.Length - output.Split('\\').Last().Count()));
            web.DownloadFile(url, output);
            log("Done!");
        }

        public static void GenerateTitleList() {
            string[] titlesUSA = File.ReadAllLines(Ref.downloads.Values.ElementAt(0));
            string[] titlesEUR = File.ReadAllLines(Ref.downloads.Values.ElementAt(1));
            string[] titlesJPN = File.ReadAllLines(Ref.downloads.Values.ElementAt(2));

            G4l.titles_usa.Clear();
            G4l.titles_eur.Clear();
            G4l.titles_jpn.Clear();

            for (int i = 1; i < titlesUSA.Count(); i++) {
                string[] info = titlesUSA[i].Split('\t');
                G4l.titles_usa.Add(new G4l.title(info[0], info[2], info[1], info[4], info[3]));
            }
            for (int i = 1; i < titlesEUR.Count(); i++) {
                string[] info = titlesEUR[i].Split('\t');
                G4l.titles_eur.Add(new G4l.title(info[0], info[2], info[1], info[4], info[3]));
            }
            for (int i = 1; i < titlesJPN.Count(); i++) {
                string[] info = titlesJPN[i].Split('\t');
                G4l.titles_jpn.Add(new G4l.title(info[0], info[2], info[1], info[4], info[3]));
            }
        }

        public static void WaitForSDRemount() {
            waitingForSDCard = true;
            CheckForSD();
            if (!waitingForSDCard) return;

            while (waitingForSDCard) {
                Thread.Sleep(500);
                CheckForSD();
            }
        }

        private static void CheckForSD() {
            foreach (DriveInfo drive in DriveInfo.GetDrives()) {
                if (drive.DriveType == DriveType.Removable && FileSystem.FileExists(drive.RootDirectory + Ref.name_breadcrumb)) {
                    if (File.ReadAllLines(drive.RootDirectory + Ref.name_breadcrumb)[0].Contains(G4l.sessionID)) {
                        G4l.sdCard = drive;
                        waitingForSDCard = false;
                    }
                }
            }
        }
    }
}
