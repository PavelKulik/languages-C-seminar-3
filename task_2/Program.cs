internal partial class Program_2
{
    private static void Main(string[] args)
    {
        int[] inputPoint(string massage, string namePoint, int count)
        {
            Console.WriteLine(massage + " " + namePoint);
            int[] arrayPoint = new int[count];
            for (int i = 0; i < arrayPoint.Length; i++)
            {
                Console.Write("Введите кординату " + (i + 1) + ": ");
                arrayPoint[i] = int.Parse(Console.ReadLine()!);
            }

            return arrayPoint;
        }

        string outputPount(int[] arrayPoint)
        {
            string result = "( ";
            for (int i = 0; i < arrayPoint.Length; i++)
            {
                result += arrayPoint[i].ToString() + " ";
            }
            return result + ")";
        }

        double distancePoint(int[] arrayPointFirst, int[] arrayPointSecond)
        {
            double distance = 0;
            for (int i = 0; i < arrayPointFirst.Length; i++)
                distance += Math.Pow(arrayPointSecond[i] - arrayPointFirst[i], 2);
            
            distance = Math.Sqrt(distance);
            return Math.Round(distance, 2);
        }

        int[] pointFirst = inputPoint("Введите кординаты точки", "A", 3);
        int[] pointSecond = inputPoint("Введите кординаты точки", "B", 3);

        Console.WriteLine(outputPount(pointFirst) + "; " + outputPount(pointSecond) + 
            " -> " + distancePoint(pointFirst, pointSecond));
    }
}