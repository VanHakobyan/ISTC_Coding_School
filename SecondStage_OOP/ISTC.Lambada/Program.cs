namespace ISTC.Lambada
{
    public delegate double Calculate(float num);
    class Program
    {
        static void Main(string[] args)
        {
            // Lambada

            Calculate calculate1 = delegate (float n) { return n * n; };     // Method
            Calculate calculate2 = (n) => { return n * n; };                 // Operator
            Calculate calculate3 = n => n * n;                               // Expression

            //calculate1=calculate1=calculate1 
        }
    }
}
