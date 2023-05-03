internal partial class Program_1
{
    private static void Main(string[] args)
    {
        bool isFiveDigitNumber(int date)
        {
            if (date.ToString().Length == 5) return true;
            else return false;
        }

        int inputDate(string massege)
        {
            Console.Write(massege);
            int date = int.Parse(Console.ReadLine()!);
            if (isFiveDigitNumber(date))
                return date;
            else
                return -1;
        }

        bool isPalindrome(int date)
        {
            string dateString = date.ToString();
            for (int i = 0; i < dateString.Length / 2; i++)
            {
                if (dateString[i] != dateString[dateString.Length - 1 - i])
                    return false;
            }

            return true;
        }

        int number = inputDate("Введите пятизначное число: ");
        if (number != -1)
        {
            Console.Write(number + " -> ");
            if (isPalindrome(number))
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
        }
        else
            Console.WriteLine("Введеное число не пятизначное!");
    }
}