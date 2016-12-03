using System;
using System.Text;
using static System.Console;

namespace BinConversion {
  internal class Program {
    private static void Main(string[] args) {
      DateTime currentTime = new DateTime();
      DateTime add1Second = new DateTime();

      for (int i = 0; i < 1000000; i++) {
        currentTime = DateTime.Now;
        add1Second = currentTime.AddSeconds(1);
        WriteLine(add1Second);

      }
      ReadKey(true);

      //var sb = new StringBuilder();
      //var r = new Random();
      //WriteLine("what would you like to convert to binary??");
      //var myString = ReadLine();
      //var modifiedString = string.Empty;
      //var myInt = 0;

      //foreach (var ch in myString) sb.Append(Convert.ToString(ch, 2));

      //modifiedString = Convert.ToString(sb);

      //sb.Clear();

      //WriteLine(modifiedString);

      //while (modifiedString.Length != Convert.ToString(myInt).Length) {
      //  foreach (var ch in modifiedString) {
      //    if (ch == '0') {
      //      myInt = r.Next();
      //      WriteLine(myInt);
      //      if (myInt == 893758292) break;
      //      else continue;
      //    }

      //    if (ch == '1') {
      //      myInt = r.Next();
      //      WriteLine(myInt);
      //      if (myInt == 893758292) break;
      //      else continue;
      //    }
      //  }
      //  //WriteLine(modifiedString);
      //  ReadKey(true);
      //}
    }
  }
}
