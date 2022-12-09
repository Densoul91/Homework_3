Console.Write("Введите размер первого массива: ");
var n1 = Convert.ToInt32(Console.ReadLine());
string[] mas1 = new string[n1];

Console.WriteLine("Введите имена для первого массива:");
for (int i = 0;i< mas1.Length;i++)
{
    Console.Write($"mas1[{i}] = ");
    mas1[i] = Console.ReadLine();
}

Console.Write("Введите размер второго массива: ");
var n2 = Convert.ToInt32(Console.ReadLine());
string[] mas2 = new string[n2];

Console.WriteLine("Введите имена для второго массива:");
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write($"mas2[{i}] = ");
    mas2[i] = Console.ReadLine();
}

var n3 = n1 + n2;
string[] result = new string[n3];

for (var i = 0; i < mas1.Length; i++)
{
    result[i] = mas1[i];
    for (var j = mas1.Length; j < result.Length; j++)
        result[j] = mas2[j - mas1.Length];
}

string[] res = result.Distinct().ToArray();




foreach (string s in res)
    Console.Write($"{s}, ");








//foreach (string m1 in mas1)
//    Console.Write($"{m1}  ");
//Console.WriteLine("");
//foreach (string m2 in mas2)
//    Console.Write($"{m2}  ");


