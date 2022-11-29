//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета
//456 -> 46
//782 -> 72
//918 -> 98


Console.Write("Введите трехзначное число: ");

int threenum = Convert.ToInt32(Console.ReadLine());

string delnum = Convert.ToString(threenum);

if (delnum.Length > 99 || delnum.Length < 999){
    Console.WriteLine("Третья цифра удаляется >");
    threenum = threenum + delnum/10;

}
else{
    Console.WriteLine("Число задано неверно");
}