using System;
 
string[] array =
{
    "Привет","22", "(8)", "much", "&&", "z"
};
 
var result = new string[array.Length];
var realSize = 0;
for(int i=0; i<array.Length; i++)
    {
       if (array[i].Length <= 3)
       {
          result[realSize] = array[i];
          realSize++;
       }
    }
 
 Console.WriteLine(string.Join(", ", result, 0, realSize));
