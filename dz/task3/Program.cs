//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string Anygnumber = Convert.ToString(number);
if (Anygnumber.Length >2){
    Console.WriteLine("Третья цифра >"+Anygnumber[2]);
}
else {
    Console.WriteLine("Третьей цифры нет");
}
