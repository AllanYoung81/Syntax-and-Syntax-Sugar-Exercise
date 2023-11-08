namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }
            //Comapring original to ternary--changed veriable names to stay within the same method...
            
            var reply = 4;
            var retort = (reply < 9) ? $"{reply} is less than nine" : $"{reply} is greater than or equal to nine";

            Console.WriteLine(response);
            Console.WriteLine(retort);
        }



    }

}
