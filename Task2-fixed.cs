using System;
  
    class MainClass {
     static int BinarySearch(int[] number, int searchedValue, int first, int last)
    {
        
        if (first > last)
        {
           
            return -1;
        }

        
        var middle = (first + last) / 2;
        
        var middleValue = number[middle];

        if (middleValue == searchedValue)
        {
            return middle;
        }
        else
        {
            if (middleValue > searchedValue)
            {
                
                return BinarySearch(number, searchedValue, first, middle - 1);
            }
            else
            {
                
                return BinarySearch(number, searchedValue, middle + 1, last);
            }
        }
    }
     
     
      
      public static void Main (string[] args) 
      
      {
          
            
             
            int[] number = new int[10]
            {22,1,3,6,9,13,44,21,7,10};
            
            
            int temp;
            for (int i = 0; i < number.Length-1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
            while (true)
        {
            int k;
            Console.Write("Введите искомое значение или выход для закрытия программы: ");
            
            var consoleNumber = Console.ReadLine().ToString();
            
            int parsedNumber;
                var tempNumber = Int32.TryParse(consoleNumber, out parsedNumber);
                if(consoleNumber == "выход")
                {
                  break;
                }
                if (tempNumber == false)
                {
                    Console.WriteLine("Вы ввели не число.");
                }
                
            

            var searchResult = BinarySearch(number, parsedNumber, 0, number.Length - 1);
            if (searchResult < 0)
            {
                Console.WriteLine("Элемент со значением {0} не найден", parsedNumber);
            }
            else
            {
                Console.WriteLine("Элемент найден. Индекс элемента со значением {0} равен {1}", parsedNumber, searchResult);
            }
        }
      } 
    }     