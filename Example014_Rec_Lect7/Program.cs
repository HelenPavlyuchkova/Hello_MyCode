// // примеры рекурсий. Обход директории

// string path = "/Users/Admin/Desktop/Examples/Example002_HelloUser";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// // $ dotnet run
// // 18.04.2022 21:55:34
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }
// //$ dotnet run
// // 18.04.2022 21:55:34
// // Example002_HelloUser.csproj
// // Program.cs

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"/Users/Admin/Desktop/Examples";//@"/Users/Admin/Desktop/Examples/Example001_HelloConsole"
// CatalogInfo(path);

// //Игра Пирамидка
// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)//with-первый рабочий шпиль, on-конечный шпиль, some-второй промежуточный шпиль, count-кол-во блинов
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);

// }
// Towers();

// //обход дерева
// string emp = String.Empty;//чтобы вся строка вмещалась без горизонтального скролла
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                  0   1    2     3     4    5   6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


