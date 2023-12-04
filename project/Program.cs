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