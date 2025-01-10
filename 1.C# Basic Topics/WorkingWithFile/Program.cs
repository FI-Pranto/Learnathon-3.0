namespace WorkingWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //File
             string sourceFile = @"D:\My Logo\FI Logo.png"; // Full source 
             string destinetionFile = @"E:\test\FI Logo.png"; // full destination of the file (V.V.I)


            File.Copy(sourceFile, destinetionFile, true);



             if (File.Exists(destinetionFile))
             {
                 File.Delete(destinetionFile);

             }

             var context=File.ReadAllText(destinetionFile);


             //FileInfo(best for large no. access)
             FileInfo fileInfo = new FileInfo(sourceFile);

              fileInfo.CopyTo(destinetionFile);

             fileInfo.Delete();
             if (fileInfo.Exists)
             {

             }
             var context2 = fileInfo.OpenRead();


            //Directory
             Directory.CreateDirectory(@"D:\folderByCode");

            var files = Directory.GetFiles(@"D:\folderByCode", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var folders = Directory.GetDirectories(@"D:\", "*.*", SearchOption.AllDirectories);
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }
            Directory.Exists("..");

            //DirectoryInfo
            var dirInfo=new DirectoryInfo("..");



            //Path
            var path = @"D:\My Logo\FI Logo.png";

            Console.WriteLine("Extension : "+Path.GetExtension(path));
            Console.WriteLine("File Name : "+Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name : " + Path.GetDirectoryName(path));







        }
    }
}
