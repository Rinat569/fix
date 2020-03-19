using System;

class MainClass {
  public static void Main (string[] args) {
    int n = 5;
    long result = 1;
    for (long i=1; i<= n; i++) {
    result = result * i;
    }
    Find(result);
  }
  public static void Find (long result) {
    Console.WriteLine(result);
    Console.ReadLine();
  }
}  

