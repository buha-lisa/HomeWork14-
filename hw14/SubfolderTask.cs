
namespace hw14
{
    class SubfolderTask
    {
        public void SearchFileInSubfolder(string path, string mask)
        {
            var files = Directory.GetFiles(path, mask);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var subDirectories = Directory.GetDirectories(path);
            foreach (var subDirectory in subDirectories)
            {
                SearchFileInSubfolder(subDirectory, mask);
            }
        }
        public void DeleteFileInSubfolder(string path, string mask)
        {
            var files = Directory.GetFiles(path, mask);
            foreach (var file in files)
            {
                File.Delete(file);
            }
            var subDirectories = Directory.GetDirectories(path);
            foreach (var subDirectory in subDirectories)
            {
                DeleteFileInSubfolder(subDirectory, mask);
            }
            Console.WriteLine("File deleted successfully.");
        }
        public void DeleteSubfolderInFolder(string path, string mask)
        {
            var subDirectories = Directory.GetDirectories(path);
            foreach (var subDirectory in subDirectories)
            {
                Directory.Delete(subDirectory);
            }
            Console.WriteLine("File deleted successfully.");
        }
    }
}
