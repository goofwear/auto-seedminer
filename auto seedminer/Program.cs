using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace auto_seedminer {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            if (File.Exists(Ref.file_log)) {
                int logCount = 0;
                foreach(string k in FileSystem.GetFiles(Ref.dir_working)) {
                    if (k.Contains("auto_seedminer_") && k.Contains(".log")) logCount++;
                }
                FileSystem.RenameFile(Ref.file_log, "auto_seedminer_" + logCount + ".log");
            }

            G4l.streamLog = FileSystem.OpenTextFileWriter(Ref.file_log, true);
            G4l.streamLog.AutoFlush = true;

            U7s.log("auto seedminer version " + Ref.ver + " launched at " + DateTime.Now.ToLongTimeString() + " on " + DateTime.Now.ToLongDateString());
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLanding());
        }
    }
}
