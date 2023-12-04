// задайте массив символов (тип char []).
// создайте строку из симполов этого массива.

// указание
// конструктор строки вида string(char []) не использовать.
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string GetStringFromCharArray (char [] chars){
    string res ="";
    foreach (char el in chars){
        res += el;
    }
    return res;
}

char [] chars = {'a','b','c','e'};
string str = GetStringFromCharArray (chars);
Console.WriteLine(str);


int [] numb = {1,2,3,4,5};
foreach (int i in numb){
    
}