using EmptyProject;

MyList<int> val = new()
{
    1,2,3,4,5
};
Console.WriteLine(val[0]);
foreach (var item in val)
{
    Console.WriteLine(item);
}



