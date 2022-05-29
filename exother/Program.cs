using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"//дан текст
                .Replace("(", "")//замените в нем скобки
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ")//возьми текст, разбей его
                .Select(item => item.Split(','))//сделай выборку по запятой
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))//сделай выборку так, чтобы первая и вторая координаты конвертировали в числа
                .Where(e => e.x % 2 == 0)//выбираем те координаты, в кот. первая координата четная
                .Select(point => (point.x * 10, point.y))//преобразовать первую координату(*10)
                .ToArray();//превратили это в массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     Console.WriteLine(data[i][k]);
    // }
    //Console.WriteLine();
}