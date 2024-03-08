//字串常見的用法

//反斜線 \ 跳脫
System.Console.WriteLine("Hello\" Jamie.");

//字串相加
System.Console.WriteLine("Hello" + "Jamie.");

//變數替代
string phrase = "Hi";
System.Console.WriteLine(phrase + "Jamie.");

//字串長度
string line = "Hi Jamie.";
System.Console.WriteLine(line.Length);

//字母大小寫
string _line = "Hey Jamie.";
System.Console.WriteLine(_line.ToUpper());
System.Console.WriteLine(_line.ToLower());

//含有子字串
string next_line = "Good morning Jamie.";
System.Console.WriteLine(next_line.Contains("Good"));
System.Console.WriteLine(next_line.Contains("Bad"));

//字串值的位置,位置去找值,或透過值去找位置
string _next_line = "Good noon Jamie.";
System.Console.WriteLine(_next_line[0]);
System.Console.WriteLine(_next_line[1]);
System.Console.WriteLine(_next_line.IndexOf("n"));
System.Console.WriteLine(_next_line.IndexOf("noon"));
System.Console.WriteLine(_next_line.IndexOf("Jamie"));

//字串切割
string the_next_line = "Good afternoon Jamie.";
System.Console.WriteLine(the_next_line.Substring(5));
System.Console.WriteLine(the_next_line.Substring(5,9));