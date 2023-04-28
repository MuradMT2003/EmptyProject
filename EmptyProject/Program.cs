//bool ContainsChar(string word,char symbol)
//{
//	for (int i = 0; i < word.Length; i++)
//	{
//		if (word[i] == symbol) return true;
//	}
//	return false;
//}
//bool ContainsSome(string word,string test)
//{
//	for (int i = 0; i < word.Length; i++)
//	{
//		string empty = "";
//		for (int j = 0; j < test.Length; j++)
//		{
//			if (word[i] != test[j])
//			{
//				break;
//			}
//			else
//			{
//				empty += word[i];
//				i++;
//			}
//		}
//		if (empty == test) return true;

//	}
//	return false;
//}
//string Remove(string word,int index)
//{
//	string some = "";
//	for (int i = 0; i < index; i++)
//	{
//		some += word[i];
//	}
//	return some;
//}
//string RemoveCount(string word, int index,int count)
//{
//    string some = "";
//    for (int i = 0; i < word.Length; i++)
//    {
//		if (i<index||i>=index+count)
//		{
//            some += word[i];
//        }
//    }
//    return some;
//}


//Console.Write("Enter word:");
//string word = Console.ReadLine();
//Console.WriteLine(word.Remove(4,1));
////Console.Write("Enter symbol:");
////char symbol = char.Parse(Console.ReadLine());
//Console.WriteLine(RemoveCount(word,4,1));
////Console.WriteLine(ContainsChar(word,symbol)?$"Yes,{word} contains {symbol}":$"No,{word} doesn't contains {symbol}");
