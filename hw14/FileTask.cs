
namespace hw14
{
    class FileTask
    {
        public void SearchFile(string path, string mask)
        {
            var files = Directory.GetFiles(path, mask);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
        public void DeleteFile(string path, string mask)
        {
            var files = Directory.GetFiles(path, mask);
            foreach (var file in files)
            {
                File.Delete(file);
            }
            Console.WriteLine("File deleted successfully.");
        }
        public void ShowAllInfo(string path)
        {
            var infos = new DirectoryInfo(path).GetFileSystemInfos();
            foreach (var info in infos)
            {
                Console.WriteLine(info.FullName);
            }
            var subDirectories = Directory.GetDirectories(path);
            foreach (var subDirectory in subDirectories)
            {
                ShowAllInfo(subDirectory);
            }
        }
    }
}
