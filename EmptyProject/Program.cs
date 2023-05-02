using EmptyProject.Models;

MyString ms = new MyString();
string some = "jjjj";
var netice= ms.Split(some, 'j');
foreach (var item in netice)
{
    Console.WriteLine(item);
}
Console.WriteLine(netice.Length);



