using System;

public interface AdvancedArithmetic{
    int divisorSum(int n);
}

/////////////// code above locked in HackerRank editor ////////////////////

class Calculator : AdvancedArithmetic{
    public int divisorSum(int n){
        int sum = 0;

        for(int i = n; i > 0; i--){
            if(n % i == 0){
                sum += i;
            }
        }

        return sum;

    }
}

/////////////// code below locked in HackerRank editor ////////////////////

class Solution{

    static void Main(string[] args){
        
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}
