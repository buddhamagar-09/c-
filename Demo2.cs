using System;
class Demo{
static void Main(){
string message = "I love you";
String upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

int x = 123;
message = message + x.ToString();
Console.WriteLine(message);
}
}