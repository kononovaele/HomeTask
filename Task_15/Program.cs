// Задача 15. Программа получает единственное число, день недели (1, 2 ... 7) и на
// выходе печатает Yes - если это выходной и No - если тяжелые будни

Console.WriteLine(" --- Task 15 ---");

Console.Write("Input digit, day of week (1, 2 ... 7), please: ");
string strDigit = Console.ReadLine();
if( strDigit == "6" || strDigit == "7" ) {
    Console.WriteLine("Yes");
}
else {
    Console.Write("No");
}
