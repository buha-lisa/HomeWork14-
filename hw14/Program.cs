namespace hw14
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-6): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;

                Console.WriteLine("Enter the path:");
                var path = Console.ReadLine();
                Console.WriteLine("Enter the mask:");
                var mask = Console.ReadLine();


                switch (task)
                {
                    case 1:
                        new FileTask().SearchFile(path, mask);
                        break;
                    case 2:
                        new SubfolderTask().SearchFileInSubfolder(path, mask);
                        break;
                    case 3:
                        new FileTask().DeleteFile(path, mask);
                        break;
                    case 4:
                        new SubfolderTask().DeleteFileInSubfolder(path, mask);
                        break;
                    case 5:
                        new SubfolderTask().DeleteSubfolderInFolder(path, mask);
                        break;
                    case 6:
                        new FileTask().ShowAllInfo(path);
                        break;
                }

            }
        }
    }
}
