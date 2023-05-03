internal class Program_3
{
    private static void Main(string[] args)
    {
        int inputDate(string massage)
        {
            Console.Write(massage);
            return int.Parse(Console.ReadLine()!);
        }

        bool isPositive(int date)
        {
            if (date > 0) return true;
            else return false;
        }

        int[] arrayCubesNumbers(int date)
        {
            int[] arrayCubes = new int[date];
            for (int i = 0; i < arrayCubes.Length; i++)
                arrayCubes[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
            
            return arrayCubes;
        }

        string outputDate(int[] arrayDate)
        {
            string result = "";
            for (int i = 0; i < arrayDate.Length; i++)
                result += arrayDate[i].ToString() + " ";
            
            return result;
        }

        int number = inputDate("Введите число: ");
        if (isPositive(number)) Console.WriteLine(number + " -> " +  outputDate(arrayCubesNumbers(number)));
        else Console.WriteLine("Число меньше 0!");
    }
}