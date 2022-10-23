// Способ вернуть сразу два значения в одном методе
int[] Method()
{
    int f = 3;
    int d = 3;
    return new int[]{f, d};
}

System.Console.WriteLine(Method()[0]);