Собрать строку с числами от a до b, a<=b
решение с использованием инеративного подхода
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}
//решение задачи через рекурсию
string NumberRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumberRec(a + 1, b);
    else return String.Empty;
}

//или, решение с вызовом рекурсии на 1 раз меньше(самостоятельно)
string NumberRec(int a, int b)
{
    if (a < b) return $"{a}" + NumberRec(a + 1, b);
    else return Convert.ToString(b);
}
System.Console.WriteLine(NumberFor(1, 10));
System.Console.WriteLine(NumberRec(1, 10));


//собрать строку с числами от a до b, a>=b
 string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i}";
    }
    return result;
}
//решение задачи через рекурсию
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a}";
    else return String.Empty;
}
System.Console.WriteLine(NumbersFor(10, 1));
System.Console.WriteLine(NumbersRec(1, 10));


//сумма чисел от 1 до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}
System.Console.WriteLine(SumFor(10));
System.Console.WriteLine(SumRec(10));


//факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if(n == 1 || n == 0) return 1;
    else return n * FactorialRec(n-1);
}
Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));



//Степень n числа a
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;//та же запись, что на следующих двух строках
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if(n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));


Перебор слов.
В некотором машинном алфавите имеются 4 буквы "а" "и" "с" "в". Покажите все
слова, состоящие из Т букв, которые можно построить из букв этого алфавита
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)//перебираем однобуквенные слова
{
    for (int j = 0; j < count; j++)//перебираем двухбуквенные слова
    {
        for (int k = 0; k < count; k++)//перебираем трехбуквенные слова
        {
            System.Console.WriteLine($"{n++,-5} {s[i]} {s[j]} {s[k]}");
        }
    }
}

решение в общем случае
char[] alphabet = { 'a', 'b', 'c', 'd' };
int wordLength = 5; // размер слова
char[] word = new char[wordLength];
int countWord = 1;
int n = 1;
for (int i = 0; i < wordLength; i++)
{
    countWord *= alphabet.Length;
}
for (int i = 0; i < countWord; i++)
{
    int param = i;
    for (int j = wordLength - 1; j >= 0; j--)
    {
        word[j] = alphabet[param % alphabet.Length];
        //Console.Write($"{param % alphabet.Length} ");
        param /= alphabet.Length;
    }
    Console.WriteLine($"{n++,-5} {new string(word)}");
}


//решение через рекурсию
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)//char[] word-массив из букв, кот.составляет новое слово
{
    if(length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for(int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[4]);


