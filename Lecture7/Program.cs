/*int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[2]);
*/

/*string path = "C:/Users/1311103/OneDrive/Рабочий стол/GB/Examples/Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);                                                   // Информация о папках
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/

/*void CatalogInfo(string path, string indent ="")       //Информация о папках и файлах по рекурсии
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

   
   FileInfo[] files = catalog.GetFiles();

   for (int i = 0; i < files.Length; i++)
   {
        Console.WriteLine($"{indent}{files[i].Name}");
   }
}
    string path = "C:/Users/1311103/OneDrive/Рабочий стол/GB/";
    CatalogInfo(path);*/

/*void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);         //перестановка блинов рекурсией
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();*/
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5     6    7   8    9    10   11
void InOrderTraversal(int pos = 1)
{
 if (pos < tree.Length)
 {
 int left = 2 * pos;
 int right = 2 * pos + 1;
 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
 Console.WriteLine(tree[pos]);
 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
 }
}
InOrderTraversal();