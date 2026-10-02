using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SingletonLibrary
{
    public class DocumentSaver
    {
        private static DocumentSaver instance;

        private string repositoryPath;
        private List<string> savedDocuments;

        private DocumentSaver()
        {
            repositoryPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DocumentsRepository"
            );

            Directory.CreateDirectory(repositoryPath);

            savedDocuments = new List<string>();
        }

        public static DocumentSaver GetInstance()
        {
            if (instance == null)
            {
                instance = new DocumentSaver();
            }

            return instance;
        }

        public string SaveDocument(string name, string content)
        {
            if (!name.EndsWith(".txt"))
            {
                name += ".txt";
            }

            string path = Path.Combine(repositoryPath, name);

            File.WriteAllText(path, content, Encoding.UTF8);

            if (!savedDocuments.Contains(path))
            {
                savedDocuments.Add(path);
            }

            return path;
        }

        public List<string> GetSavedDocuments()
        {
            return new List<string>(savedDocuments);
        }

        public string GetRepositoryPath()
        {
            return repositoryPath;
        }
    }
}
