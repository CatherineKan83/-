Console.Write("Введите величину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] First = new string[n];
string []Result = new string[n];
int k=0;
int i=0;
Console.Write("Введите элементы массива(не обязательно числа): ");
for(;i<n; i++)
{
    First[i]=$"{Console.ReadLine()}";
    if(First[i].Length<=3)
    {
        Result[k]=First[i];
        k++;
    }
}
k=0;
Console.Write("[");
foreach(string value in Result)
{
    if(value!=null)
    {
        Console.Write($" '{value}'"); 
        if(Result[k+1]!=null)
        {
            Console.Write(",");
        }
        k++;
    }
}
Console.Write("]");