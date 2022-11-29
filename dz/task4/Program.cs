//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите день недели цифрой: ");
int date = Convert.ToInt32(Console.ReadLine());
void CheckDay (int date) {
    if (date==6 || date==7){
        Console.WriteLine("Выходной день");
    }
    else if (date < 1 || date > 7){
        Console.WriteLine("Не существует");
    }
    else Console.WriteLine("Рабочий день ");
}
CheckDay(date);