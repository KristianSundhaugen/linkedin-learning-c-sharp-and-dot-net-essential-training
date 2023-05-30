// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
System.Console.WriteLine(str1.Length);

// TODO: Access individual characters
// System.Console.WriteLine(str1[14]);

// TODO: Iterate over a string like any other sequence of values
// foreach (char ch in str1) {
//     Console.WriteLine(ch);
//     if(ch == 'b'){
//         System.Console.WriteLine();
//         break;
//     }
// }

// TODO: String Concatenation         
// string outstr;
// outstr = String.Concat(strs);

// TODO: Joining strings together with Join
// outstr = String.Join('.', strs);
// System.Console.WriteLine(outstr);
// outstr = String.Join("---", strs);
// System.Console.WriteLine(outstr);

// TODO: String Comparison
// bool isEqual = str2.Equals(str3);
// System.Console.WriteLine($"{isEqual}");

// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);
// Console.WriteLine($"{isEqual}");
// int result = string.Compare(str2, "This is string");
// System.Console.WriteLine($"{result}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order


// TODO: Replacing content
string outstr = str1.Replace("fox", "cat");
System.Console.WriteLine($"{outstr}");