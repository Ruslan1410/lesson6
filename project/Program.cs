// задайте массив символов (тип char []).
// создайте строку из симполов этого массива.

// указание
// конструктор строки вида string(char []) не использовать.
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string GetStringFromCharArray (char [] chars){
//     string res ="";
//     foreach (char el in chars){
//         res += el;
//     }
//     return res;
// }

// char [] chars = {'a','b','c','e'};
// string str = GetStringFromCharArray (chars);
// Console.WriteLine(str);


// int [] numb = {1,2,3,4,5};
// foreach (int i in numb){

// }

// На основе символов строки (тип string) сформировать 
// массив символов (тип char[]). Вывести массив на экран.

// Указание
// Метод строки ToCharArray() не использовать.

// char [] StringToCharArray(string str){
//     char [] chars = new char [str.Length];
//     for (int i=0; i<str.Length; i++){
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void ShowCharsArr(char [] chars){
//     foreach(char elem in chars){
//         Console.Write(elem+" ");
//     }
// }

// string str = "Hello world!";
// char [] chars = StringToCharArray(str);
// ShowCharsArr(chars);

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

// int GetCountVovelsInString(string str)
// {
//     string vovels = "aeiou"; 
//     int count = 0;
//     foreach(char elem in str)
//     {
//         foreach(char vol in vovels)
//         {
//             if(vol == elem)
//             {
//                 count++;
//             }
//         }
//     }
//     return count;
// }




// string str = "Hello world";
// int chars = GetCountVovelsInString(str);
// Console.WriteLine ($"Vovels in {str} is {chars}");

// string str = "world";
// string str1 ="wfefgwdf";
// int chars = GetCountVovelsInString (str, str1);
// Console.WriteLine($"Count of inc")