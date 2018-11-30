namespace ISTC.Lambada
{
    public delegate double Calculate(float num);

    class Program
    {
        /// <summary>
        /// explicit static method
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Method(float n)
        {
            return n * n;
        }

        static void Main(string[] args)
        {
            
            Calculate calculate0 = Method; // Method explicit 
         
            // Lambada
            Calculate calculate1 = delegate(float n) { return n * n; }; // Method
            Calculate calculate2 = (n) => { return n * n; };            // Operator
            Calculate calculate3 = n => n * n;                          // Expression

            //calculate1=calculate1=calculate1 
        }
    }

}