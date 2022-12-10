#region Homework 3-1


using System.Globalization;

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
#endregion


//string[] res = result.Distinct().ToArray();




string[] res= new string[n3];
int k = 1;
for (int i =0; i<n3;i++)
{
    for (int j = i + 1; j < n3; j++)
    {
        if (result[j] == result[i])
        {
            //for (int k = j; k < n3 - 1; k++)
            //{

            result[k] = result[j+1];
            k++;
            n3--;
            //break;
            //}
           // n3--;
        }
        else
        {
            //n3--;
            continue;
        }
    }
}











    foreach (string s in result)
        Console.Write($"{s}, ");

