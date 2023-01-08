// Задача 13. Программа выводит 3-ую цифру введенного числа
// если третьей цифры нет, то ругается

Console.WriteLine(" --- Task 15 ---");

Console.Write("Input any digit, please: ");
string strDigit = Console.ReadLine();
if( strDigit.Length < 3 ) {
    Console.WriteLine("There is not third digit, sorry!!!");    
}
else {
    Console.Write("The third digit is: ");
    Console.WriteLine(strDigit[2]);
}
