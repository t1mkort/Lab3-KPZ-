using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SingletonLibrary
{
    public class Logger
    {
        private static Logger instance;

        private List<string> text;
        private string filePath;

        private Logger()
        {
            text = new List<string>();

            filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "log.txt"
            );
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(string message)
        {
            string record =
                DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")
                + " - "
                + message;

            text.Add(record);

            File.AppendAllText(
                filePath,
                record + Environment.NewLine,
                Encoding.UTF8
            );
        }

        public List<string> GetStrings()
        {
            return new List<string>(text);
        }

        public string GetFilePath()
        {
            return filePath;
        }
    }
}