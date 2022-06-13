using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please enter an amount to convert: ");
      string amountAsStringInput = Console.ReadLine();
      double conversion = Convert.ToDouble(amountAsStringInput); 
      //inform user that the conversion is about to start
      Console.WriteLine($"{conversion} cents is equal to...");

      //Define variables: 
      int goldCoinValue = 10;
      int silverCoinValue = 5;
      //find max "times" gold coin fits into the amount specified
      double goldCoins = Math.Floor(conversion / goldCoinValue);
      //store remainder
      double remainder = conversion % goldCoinValue;
      //find max "times" silver fits into remainder amount
      double silverCoins = Math.Floor(remainder / silverCoinValue);
      remainder = remainder % silverCoinValue;

      //print to console
      Console.WriteLine($"Gold coins: {goldCoins} \n Silver coins: {silverCoins} \n Bronze coins : {remainder}");
    }
  }
}
