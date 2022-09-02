var n = new List<int>();
for(int i=0;i<=84;i++)
{
    int year = 2022+i;
    int days = DateTime.DaysInMonth(year,2);

    if(days == 29)
    {
        n.Add(year);
    }
}

foreach(int r in n)
{
    Console.WriteLine($"The year {r} is a leap year");
}
Console.WriteLine(n.Count);
