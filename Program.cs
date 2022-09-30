// See https://aka.ms/new-console-template for more information

/*პირველი სავარჯიშო
 
string[] namesArray = new string[] {};

var namesList = namesArray.ToList();

for (int i = 1; i < 11; i++)
{
    var value = Console.ReadLine();
    namesList.Add(value);
}

namesArray = namesList.ToArray();
Console.WriteLine();
foreach (var item in namesArray)
{
    Console.WriteLine(item);
}
*/

// ---------------------------------------------------------------------------

/*მესამე სავარჯიშო

var multiplication = 1;
var sum = 0;
var myValue = Console.ReadLine();
int x = Int32.Parse(myValue);
for (int i = 1; i < x+1; i++)
{
    if(i % 2 == 1){
        multiplication *= i;
        sum += i;
    }
}

Console.WriteLine($"multiplication of odd numbers is {multiplication}");
Console.WriteLine($"sum of odd numbers is {sum}");
*/

// ---------------------------------------------------------------------------

/*მეოთხე სავარჯიშო

var myValue = Console.ReadLine();
int x = Int32.Parse(myValue);
double sumOfSquares = 0;
for (int i = 1; i < x + 1; i++)
{
    double square = i * i;
    sumOfSquares += square;
}
Console.WriteLine($"sum of Square numbers is {sumOfSquares}");
*/

// ---------------------------------------------------------------------------

/*მეხუთე სავარჯიშო

var myValue = Console.ReadLine();
var myCharValue = myValue.ToCharArray();
var reversedString = "";
for(int i = myValue.Length - 1; i > -1; i--)
{
    reversedString += myValue[i];
}
if (myValue.ToLower() == reversedString.ToLower())
{
    Console.WriteLine("it is palindrom");
}
else
{
    Console.WriteLine("it is not palindrom");
}
*/

// ---------------------------------------------------------------------------

/*მეექვსე სავარჯიშო

var myValue = Console.ReadLine();
int x = Int32.Parse(myValue);  //x=1234
int equalToXFoFirstWhileLoop = x;
int equalToXForSecondWhileLoop = x;
int m = 0;
double isItPalindromeNumber = 0;
while(equalToXFoFirstWhileLoop / 10 > 0)
{
    m += 1;
    equalToXFoFirstWhileLoop = equalToXFoFirstWhileLoop / 10;
}
while(m > -1)
{
    var power = Math.Pow(10, m);
    isItPalindromeNumber += (equalToXForSecondWhileLoop % 10) * power;
    equalToXForSecondWhileLoop = equalToXForSecondWhileLoop / 10;
    m -= 1;
}

Console.WriteLine(x);
Console.WriteLine(isItPalindromeNumber);


if(x == isItPalindromeNumber)
{
    Console.WriteLine("it is palindrom");
}
else
{
    Console.WriteLine("it is not palindrom");
}

*/


/*მერვე სავარჯიშო

double[] arr1 = new double[] {  -5, 32, 645, -24, -13, 449, -245, 53 };
double maxNum = arr1[0];
double minNum = arr1[0];

for(int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] <= minNum)
    {
        minNum = arr1[i];
    }
    if (arr1[i] >= maxNum)
    {
        maxNum = arr1[i];
    }
}
double median = 0;
Array.Sort(arr1);
if(arr1.Length % 2 == 1)
{
    var a = arr1.Length/ 2;
    median = arr1[a];
}
else
{
    median = (arr1[arr1.Length / 2] + arr1[arr1.Length / 2 - 1]) / 2;
}
Console.WriteLine(minNum);
Console.WriteLine(maxNum);
Console.WriteLine(median);
*/

// ---------------------------------------------------------------------------

/*მეცხრე სავარჯიშო

int[] arr1 = new int[] { 2, -5, 32, 645, -24, -13, 449, -245, 53 };
int[] arr2 = new int[] { };
var myNewListedArray = arr2.ToList();
for(int i = arr1.Length - 1; i > -1; i--)
{
    myNewListedArray.Add(arr1[i]);
}
arr1 = myNewListedArray.ToArray();
foreach(var num in arr1)
{
    Console.WriteLine(num);
}
*/

// ---------------------------------------------------------------------------

/*მეათე სავარჯიშო

int[] arr = new int[] {2, -5, 32, 645, -24, -13, 449, -245, 53};
var numberOfNegativeNums = 0;
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        numberOfNegativeNums += 1;
    }
}
Console.WriteLine($"number of negatives is {numberOfNegativeNums}");
*/

// ---------------------------------------------------------------------------

/*მეცამეტე სავარჯიშო

var newString = Console.ReadLine();
string[] marksArray = new string[] { "+", ",", ".", "-", "'", "\"", "&", "!", "?", ":", ";", "#", "~", "=", "/", "$", "£", "^", "(", ")", "_", "<", ">" };
var chars = newString.ToCharArray();
var emptySpaces = 0;
var lowers = 0;
var uppers = 0;
var marks = 0;
foreach(var item in chars)
{
    if(item == ' ')
    {
        emptySpaces += 1;
    }
    else if(item.ToString() == item.ToString().ToLower())
    {
        lowers += 1;
    }
    else if(item.ToString() == item.ToString().ToUpper())
    {
        uppers +=1;
    }

    for(int i = 0; i< marksArray.Length; i++)
    {
        if(item.ToString() == marksArray[i])
        {
            marks += 1;
        }
    }
}

Console.WriteLine($"number of words in text is {emptySpaces + 1}");
Console.WriteLine($"number of lowercases is {lowers}");
Console.WriteLine($"number of uppercases is {uppers}");
Console.WriteLine($"number of punctuation marks is {marks}");

*/

// ---------------------------------------------------------------------------

/*მეთოთხმეტე სავარჯიშო

char[] vowelsArray = new char[] {'a', 'e', 'i', 'o', 'u', 'y'};
var vowelNumber = 0;
var consonantNumber = 0;
var myString = Console.ReadLine();
var myStringToLower = myString.ToLower();
var myStringToCharArray = myStringToLower.ToCharArray();

for (int i = 0; i < myStringToCharArray.Length; i++){
    for(int j = 0; j < vowelsArray.Length; j++)
    {
        if (myStringToCharArray[i] == vowelsArray[j])
        {
            vowelNumber += 1;
        }
    }
    
}
Console.WriteLine($"vowels number is: {vowelNumber}");
Console.WriteLine($"consonants number is: {myStringToCharArray.Length - vowelNumber}");

*/

// ---------------------------------------------------------------------------

/*მეთხუთმეტე სავარჯიშო

using System;

var mainString = Console.ReadLine();
var containString = Console.ReadLine();
bool contains = mainString.ToLower().Contains(containString.ToLower());
if (contains)
{
    Console.WriteLine("it contains");
}
else
{
    Console.WriteLine("it doesnt contain");
}
*/

// ---------------------------------------------------------------------------


/*მეთექვსმეტე სავარჯიშო
var myString = Console.ReadLine();
var myStringToCharArray = myString.ToCharArray();
if (myString.Length > 10)
{
    var finalWord = myStringToCharArray[0] + $"{myString.Length - 2}" + myStringToCharArray[myString.Length - 1];
    Console.WriteLine(finalWord);
}
else
{
    var finalWord = myString;
    Console.WriteLine(finalWord);
}
*/

// ---------------------------------------------------------------------------


