namespace RootLib
{
    public class Root
    {
        public static double MyRoot(double number)
        {
            double root;
            root = Math.Sqrt(number);
            Console.WriteLine("The square root of " + number + " is " + root);
            return root;
        }

    }
}
