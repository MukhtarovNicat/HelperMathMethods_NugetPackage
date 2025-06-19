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
}
