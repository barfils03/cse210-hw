using System;
// WK01 Monica Solis Loops Magic number

class Program
{
    static void Main(string[] args)
    {

        string messageReceived="Nothing";
        int tryTimes=0;
        
        Random magicNumber = new Random();
        int magicNumberInt= magicNumber.Next(1,100);

        do {

            Console.WriteLine("What is your guess?");
            string guessNumber=Console.ReadLine();
            int guessNumberInt= int.Parse(guessNumber);

            if (guessNumberInt < magicNumberInt){
                messageReceived="Higher";
         
            }else  if (guessNumberInt > magicNumberInt){
                messageReceived="Lower";
              
            } else{
                Console.WriteLine("You guessed it!\nDo you want to play? yes or no");
                string wanaPlay= Console.ReadLine();
                if (wanaPlay == "yes"){
                    messageReceived="";
                }else{
                    messageReceived="You guessed it!";
                }
            }
            tryTimes++;
            Console.WriteLine($"{messageReceived}");
        } while (messageReceived != "You guessed it!");

        Console.WriteLine($"{tryTimes} attemps");
        
    }
 
}