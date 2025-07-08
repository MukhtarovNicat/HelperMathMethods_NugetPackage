namespace HelperMathMethods.Servives.MathMetods;

public class MathMetodsService : IMathMethodsService
{
    /// <summary>
    /// Finds the largest number in the collection
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int FindBigNumberInCollection(List<int> numbers)
    {
        var orderList = numbers.OrderByDescending(x => x).ToList();
        return orderList[0];
    }

    /// <summary>
    /// Find Sum
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int SumToInteger(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Multiply numbers
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MultiplyNumbers(params int[] nums)
    {
        var res = 1;
        foreach (var num in nums)
        {
            res *= num;
        }

        return res;
    }

    /// <summary>
    /// Division Numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public decimal DivisionNumber(int a, int b)
    {
        return (decimal)a / b;
    }

    /// <summary>
    /// Find avarage in the collection
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public decimal FindAvarage(params int[] nums)
    {
        var sum = 0;
        var listLength = nums.Count();
        foreach (var num in nums)
        {
            sum += num;
        }
        var res = (decimal)sum / listLength;
        return res;
    }

    /// <summary>
    /// Determines whether the specified integer is an even number.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public bool IsEven(int number)
    {
        if (number <= 0) throw new Exception("Must be grather than 0");

        bool isOdd = false;

        if (number % 2 == 0)
            isOdd = true;

        return isOdd;
    }

    /// <summary>
    /// Returns a collection containing only the even numbers from the specified input collection.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public ICollection<int> FindEvenNumbers(ICollection<int> numbers)
    {
        ICollection<int>? oddNumbers = new List<int>();

        if (numbers.Count > 0)
            foreach (var num in numbers)
                if (num % 2 == 0)
                    oddNumbers.Add(num);

        return oddNumbers;
    }

    /// <summary>
    /// Calculates the factorial of each number in the specified collection.
    /// A collection of non-negative decimal numbers.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public decimal FindFactorial(ICollection<decimal> numbers)
    {
        decimal factorial = 1;
        foreach (var num in numbers)
        {
            if (num > 0)
                factorial *= num;
        }

        return factorial;
    }

    /// <summary>
    /// Sorts the given collection of integers in descending order
    /// and returns the specified number of largest elements from the top of the sorted list.
    /// </summary>
    /// <param name="numbers">The collection of integers to process.</param>
    /// <param name="count">The number of top (largest) values to return.</param>
    /// <returns>
    /// A collection containing the largest <paramref name="count"/> numbers from the input list, sorted in descending order.
    /// </returns>
    /// <remarks>
    /// The method uses a simple in-place sorting algorithm (bubble sort) to order the numbers from highest to lowest
    /// before selecting the top <paramref name="count"/> items.
    /// </remarks>
    public ICollection<int> TakeTopNumbers(ICollection<int> numbers, int count)
    {
        var numList = numbers.ToList();
        for (int i = 0; i < numList.Count - 1; i++)
        {
            for (int j = i + 1; j < numList.Count; j++)
            {
                if (numList[i] < numList[j])
                {
                    var temp = numList[i];
                    numList[i] = numList[j];
                    numList[j] = temp;
                }
            }
        }
        return numList.Take(count).ToList();
    }

    /// <summary>
    /// Generates the multiplication table for a given number from 1 to 10.
    /// </summary>
    /// <param name="num">The number for which the multiplication table will be generated.</param>
    /// <returns>A list of strings, each representing one line of the multiplication table (e.g., "5 * 3 = 15").</returns>
    public List<string> MultiplicationTable(int num)
    {
        List<string> multiplication = new List<string>();
        for (int i = 1; i <= 10; i++)
        {
            multiplication.Add($"{num}" + " * " + $"{i}" + " = " + $"{num * i}");
        }

        return multiplication;
    }
}
