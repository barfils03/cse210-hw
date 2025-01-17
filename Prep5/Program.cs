using System;
/// wk01 monica solis functions
/// DisplayResult - Accepts the user's name and the squared number and displays them.
/// </summary>
class Program
{
    static void Main(string[] args)
    {

        static string DisplayWelcome()
        {
            string messageWelcome ="Welcome to the Program!";
            return messageWelcome;
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string usrName = Console.ReadLine();
            return usrName;
        }




        int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            string usrFavoritenum = Console.ReadLine();
            return int.Parse(usrFavoritenum);
        }

        int SquareNumber(int varNumber)
        {
            int varSquare=varNumber*varNumber;
            return varSquare;
        }

        void DisplayResult(string usrNameRec, int usrSquareRec )
        {
            Console.WriteLine($"Hi! {usrNameRec}, the square of your number is {usrSquareRec}");

        }

        
        
        string varWelcome=DisplayWelcome();
        Console.WriteLine(varWelcome);
        string varUsrName=PromptUserName();
        int varUsrNumber=PromptUserNumber();
        int varUsrsquere=SquareNumber(varUsrNumber);

        DisplayResult(varUsrName, varUsrsquere);

    }
}