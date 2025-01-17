using System;
//this is wk01 Monica Solis -  Letter Grade Sacle
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string varScale = Console.ReadLine();
        int varScaleint = int.Parse(varScale);
        string varScaleletter;
        int varNumber;
        
      
        if (varScaleint >= 90)
        { 
            varScaleletter="A";
            varNumber=varScaleint-90;
            if (varNumber > 3){
                varNumber=5;
            }
        }else if (varScaleint >= 80 && varScaleint < 90 )
        {
            varScaleletter="B";
            varNumber=varScaleint-80;
        }else if (varScaleint >= 70 && varScaleint < 80 )
        {
            varScaleletter="C";
            varNumber=varScaleint-70;
        }else if (varScaleint >= 60 && varScaleint < 70 )
        {
            varScaleletter="D";
            varNumber=varScaleint-60;
        }else
        {
              varScaleletter="F";
              varNumber=5;
        }

        string messageTouser;

        if (varScaleint > 69)
        {
            messageTouser="Congratulations! You have got ";
        }else{
            messageTouser="Sorry you will need to retake the course! You got ";
        }


        string varSignal="";
        if (varNumber <= 3)
        {
            varSignal="-";
        }else if (varNumber >= 7)
        {
            varSignal="+";
        } 
        
        Console.WriteLine($"{messageTouser} {varSignal}{varScaleletter}");
    }
}