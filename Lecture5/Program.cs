using System.Linq;

// Как не стоит писать код
/*int a = 12;
Console.WriteLine(a.GetType().Name);*/

var a = 12;
//Console.WriteLine(a.GetType());

var data = new int[]{1, 23, 4}
        .Where(e=> e > 0)
        .Select(e => new {q = e, w = e + 1});
Console.WriteLine(data.GetType().Name);   // Убрать Name и будет по другому о необходимости var