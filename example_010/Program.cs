// //Вид1 прнимает и ничего не возвращает

// void Method1()
// {
//     Console.WriteLine("блабла") // прнимает и ничего не возвращает
// }

// Method1();

// //Вид 2и принимает и возвращает

// void Method2(string msg)
// {
//     Console.WriteLine(msg) // и принимает и возвращает
// }
// Method2("Текст сообщения");

// void Method2(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);  // и принимает и возвращает
//         i++;
//     }
// }
// Method2(msg: "Текст", count: 4); //где 4 количество раз вывода

// // Вид 3 возвращает но ничего не принимает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year=Method3();
// Console.WriteLine(year);

// // Вид 4 что-то принимают и что-то возвращают

// string Method4(int count, string c)
// {
//     int i=0;
//     string result=String.Empty;

//     while (i<count)
//     {
//         result=result+c;
//         i++;
//     }
//     return result;

// }
// string res=Method4(10,"asdf"); //количество раз, "что выводит"
// Console.WriteLine(res);