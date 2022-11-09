string path = "путь к папке";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent} {files[i].Name}");
    }
}
string path = @"путь к папке";
CatalogInfo(path);

