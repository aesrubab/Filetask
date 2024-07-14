using System.Text;

class Program
{
    static void Main(string[] args)
    {
        ////Folder yarat
        //string folderPath = "text.txt";
        //if (!Directory.Exists(folderPath))
        //{
        //    Directory.CreateDirectory(folderPath);
        //    Console.WriteLine("Folder yaradıldı: " + folderPath);
        //}
        //else
        //{
        //    Console.WriteLine("Folder artıq mövcuddur: " + folderPath);
        //}

        ////Oldugu directory

        //string currentDirectory = Directory.GetCurrentDirectory();

        //Console.WriteLine("directory: " + currentDirectory);


        ////Folderi sil
        //if (Directory.Exists(folderPath))
        //{
        //    Directory.Delete(folderPath, true);
        //    Console.WriteLine("Folder silindi: " + folderPath);
        //}
        //else
        //{
        //    Console.WriteLine("Bele folder mövcud deyil: " + folderPath);
        //}

        //File yarat

        //string filePath = "yeni.txt";

        //using (FileStream fs = File.Create(filePath))
        //{
        //    byte[] info = new UTF8Encoding(true).GetBytes("new file");
        //    fs.Write(info, 0, info.Length);
        //}

        //Console.WriteLine("Fayl yaradıldı: " + filePath);


        //fayli sil
        //string filePath = "yeni.txt";

        //if (File.Exists(filePath))
        //{
        //    File.Delete(filePath);
        //    Console.WriteLine("Fayl silindi " + filePath);
        //}
        //else
        //{
        //    Console.WriteLine("Fayl tapılmadı " + filePath);
        //}



        //File i kocur
        //string sourceFile = "c:\\Users\\user\\Desktop\\folder1\\fayl.txt";
        //string destiantionFile = "c:\\Users\\user\\Desktop\\folder2\\fayl3.txt";

        //if (File.Exists(sourceFile))
        //{
        //    File.Copy(sourceFile, destiantionFile);
        //} 
        //else
        //{
        //    Console.WriteLine("Somewhing went wrong!");
        //}


        //File i axtarmaq
      
        //string fileName = "fayl.txt";
        //string directory = "c:\\Users\\user\\Desktop\\folder1";
        //if(File.Exists(fileName)) {
        //    Console.WriteLine($"{fileName} fayl tapildi");
        //}
        //else
        //{
        //    Console.WriteLine($"{fileName} fayl tapilmaddi");
        //}

        //bele de olar ba

        //try
        //{
        //    string[] files = Directory.GetFiles(directory,fileName);
        //    if (files.Length > 0)
        //    {
        //        foreach (string file in files)
        //        {
        //            Console.WriteLine(file);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fayl tapilmadi");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Xeta bas verdi : {ex.Message}");
        //    throw;
        //}

        //Butun fayllari gormek

        string directory = "c:\\Users\\user\\Desktop";
        foreach (var item in Directory.GetFiles(directory))
        {
            Console.WriteLine(item);
        }

   
    }
}