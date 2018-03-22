# String Class

Class String represents text as a series of Unicode characters.
### String.Chars Property
Gets the Char object at a specified position in the current String object.
```C#
string str1 = "Test";
for (int ctr = 0; ctr <= str1.Length - 1; ctr++ )
   Console.Write("{0} ", str1[ctr]);  // T e s t         
```

### String.Length Property
Gets the number of characters in the current String object.
```C#
string str = "abcdefg";
Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);
// The length of 'abcdefg' is 7
// The length of 'xyz' is 3
```
### String.Compare Method (String, String)
Compares two specified String objects and returns an integer that indicates their relative position in the sort order.
A 32-bit signed integer that indicates the lexical relationship between the two comparands.
Less than zero   ->   strA is less than strB.
Zero   ->   strA equals strB.
Greater than zero  ->   strA is greater than strB.

### String.Compare Method (String, String, Boolean)
Compares two specified String objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.
```C#
public static int Compare(string strA, string strB, bool ignoreCase)
```
ignoreCase
Type: System.Boolean
true to ignore case during the comparison; otherwise, false.

### String.Equals Method (String)
Determines whether this instance and another specified String object have the same value.
```C#
Console.OutputEncoding = System.Text.Encoding.UTF8;
string word = "File";
string[] others = { word.ToLower(), word, word.ToUpper(), "fıle" };
foreach (string other in others)
{
    if (word.Equals(other)) 
    Console.WriteLine("{0} = {1}", word, other);
    else
    Console.WriteLine("{0} {1} {2}", word, '\u2260', other);
}   
```  
### String.Equals Method (String, String)
Determines whether two specified String objects have the same value.
```C#
StringBuilder sb = new StringBuilder("abcd");
string      str1 = "abcd";
string      str2 = null;
Console.WriteLine(" *  The value of StringBuilder sb is '{0}'.", sb.ToString());

Console.WriteLine("1a) string.Equals(Object). Object is a StringBuilder, not a String.");
Console.WriteLine("Is str1 equal to sb?: {0}", str1.Equals(sb)); //Is str1 equal to sb?: False

str2 = sb.ToString();
Console.WriteLine("Is str1 equal to str2?: {0}", str1.Equals(str2));//Is str1 equal to str2?: True
```
### String.GetEnumerator Method
```C#
static void EnumerateAndDisplay(string phrase)
{
      Console.WriteLine("The characters in the string \"{0}\" are:", phrase);

      int CharCount = 0;  
      int controlChars = 0;  
      int alphanumeric = 0;  
      int punctuation = 0;

      foreach (var ch in phrase) {
         Console.Write("'{0}' ", 
                ! Char.IsControl(ch) 
                ? ch.ToString() 
                : "0x" + Convert.ToUInt16(ch).ToString("X4"));
         if (Char.IsLetterOrDigit(ch)) 
            alphanumeric++;
         else if (Char.IsControl(ch)) 
            controlChars++;
         else if (Char.IsPunctuation(ch)) 
            punctuation++;             
         CharCount++;
      }

      Console.WriteLine("\n   Total characters:        {0,3}", CharCount);
      Console.WriteLine("   Alphanumeric characters: {0,3}", alphanumeric);
      Console.WriteLine("   Punctuation characters:  {0,3}", punctuation);
      Console.WriteLine("   Control Characters:      {0,3}\n", controlChars);
}
//    The characters in the string "Has       two     tabs" are:
//    'H' 'a' 's' '0x0009' 't' 'w' 'o' '0x0009' 't' 'a' 'b' 's' 
//       Total characters:         12 
//       Alphanumeric characters:  10 
//       Punctuation characters:    0 
//       Control Characters:        2 
```
### String.IndexOf Method (String)
Reports the zero-based index of the first occurrence of the specified string in this instance.
```C#
string animal1 = "fox";
string animal2 = "dog";

string strTarget = String.Format("The {0} jumped over the {1}.", animal1, animal2);
Console.WriteLine("The original string is:{0}{1}{0}", Environment.NewLine, strTarget);
adj1 ="bold "; 
adj2 ="lazy ";
strTarget = strTarget.Insert(strTarget.IndexOf(animal1), adj1);
strTarget = strTarget.Insert(strTarget.IndexOf(animal2), adj2);

Console.WriteLine("{0}The final string is:{0}{1}", Environment.NewLine, strTarget);
//The original string is: 
//       The fox jumped over the dog. 
//The final string is: 
//       The bold fox jumped over the lazy dog.
```
### String.IndexOf Method (Char, Int32)
Reports the zero-based index of the first occurrence of the specified Unicode character in this string. The search starts at a specified character position.
```C#
string str = "Now is the time for all good men to come to the aid of their party.";
int start = 0;
int at = 0;
while((start < str.Length) && (at > -1))
{
        at = str.IndexOf('t', start);
        if (at == -1) break;
        Console.Write("{0} ", at);
        start = at+1;
}
// Now is the time for all good men to come to the aid of their party.
// The letter 't' occurs at position(s): 7 11 33 41 44 55 64

String.IndexOf Method (String, Int32)
string strSource = "This is the string which we will perform the search on";
string strTarget = "";  int found = 0;  int totFinds = 0;

do {
      Console.Write("Please enter a search value to look for in the above string ");
      strTarget = Console.ReadLine();

      if (strTarget != "") 
      {
          for (int i = 0; i < strSource.Length; i++) 
          {
               found = strSource.IndexOf(strTarget, i);
               if (found > 0) 
               {
                      totFinds++;
                      i = found;
               }
               else   break;
           }
      }
      else  return;

      Console.WriteLine("{0}The search parameter '{1}' was found {2} times.{0}",
                    Environment.NewLine, strTarget, totFinds);
      totFinds = 0;
} while ( true );
```
### Get lenght of the string
```C#
string text = "somestring";
Console.WriteLine(text + " lenght -> " + text.Length);
```
### Convert to uppercase
```C#
text = text.ToUpper();
Console.WriteLine("ToUpper ->" + text);
```
### Convert to lowercase
```C#
text = text.ToLower();
Console.WriteLine("ToLower ->" + text);
```
### Substring -  get the first 4 characters
```C#
Console.WriteLine("Substring - get first four characters:");
string substring = text.Substring(0, 4);
Console.WriteLine("Substring: {0}", substring);
```
### Remove leading or trailing whitespace
```C#
string removeSpace = "  some string text  ";
Console.WriteLine("Remove leading or trailing whitespace: " + "!" + removeSpace + "!");
Console.Write("!");
Console.Write(removeSpace.Trim());
Console.WriteLine("!");
```
### Split string
```C#
string stringSample = "This is an example for string split";
Console.WriteLine("Split string on spaces.This will separate all words of the string.");
string[] words = stringSample.Split(' ');
foreach (string word in words)
{
    Console.WriteLine(word);
}
```
### IndexOf method - one of the searching methods
```C#
Console.WriteLine("IndexOf method:");
if (stringSample.IndexOf("example") != -1)
{
    Console.Write("string contains 'example'");
}
```
### Copy string
```C#
Console.WriteLine("Copy a literal string");
string sample = "This is a string";
string copySample = string.Copy(sample);
Console.Write("First string: ");
Console.WriteLine(sample);
Console.Write("Second string: ");
Console.WriteLine(copySample);
```
### See if the references are equal
```C#
Console.WriteLine("Are two strings Equal?: " + object.ReferenceEquals(sample, copySample));
Console.WriteLine("That is because the object data is equivalent in both objects, but the data ");
Console.WriteLine("is not in the same storage location and the references are unequal.");
```
### Concatenation
```C#
Console.WriteLine(Environment.NewLine + "Concatenation of strings:");
sample = string.Concat(sample, " and ", copySample);
Console.WriteLine(sample);
```
### Replace
```C#
Console.WriteLine(Environment.NewLine + "Replace text in string:");
string replace = copySample.Replace("This", "That");
Console.WriteLine(replace);
```
### Append
```C#
Console.WriteLine("Append the word \"NEW\" to the previous string.");
copySample += " NEW";
Console.WriteLine(copySample);
```
### Compare strings
```C#
string first = "First string";
string second = "Second string";
Console.WriteLine("Compare strings: " + first + ", " + second);
Console.WriteLine("If the first string is bigger, the result is 1. If the first string is smaller, the result is -1.");
Console.WriteLine("If both strings are equal, the result is 0. The number essentially indicates how much larger the first string is.");
int compare = string.Compare(first, second);
Console.WriteLine("Compare first, second " + compare);
 
compare = string.CompareOrdinal(second, first);
Console.WriteLine("Compare second, first " + compare);
 
compare = first.CompareTo(second);
Console.WriteLine("first.CompareTo(second) " + compare);
 
compare = second.CompareTo(first);
Console.WriteLine("second.CompareTo(first) " + compare);
```
