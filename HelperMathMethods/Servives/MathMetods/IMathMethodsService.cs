
namespace HelperMathMethods.Servives.MathMetods;

public interface IMathMethodsService
{
    /// <summary>
    ///  Find Sum
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    int SumToInteger(int a, int b);

    /// <summary>
    /// Finds the largest number in the collection
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    int FindBigNumberInCollection(List<int> numbers);

    /// <summary>
    /// Multiply numbers
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    int MultiplyNumbers(params int[] nums);

    /// <summary>
    /// Division Numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    decimal DivisionNumber(int a, int b);

    /// <summary>
    /// Find avarage in the collection
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    decimal FindAvarage(params int[] nums);

    /// <summary>
    /// Determines whether the specified integer is an even number.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    bool IsEven(int number);

    /// <summary>
    /// Returns a collection containing only the even numbers from the specified input collection.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    ICollection<int> FindEvenNumbers(ICollection<int> numbers);

    /// <summary>
    /// Calculates the factorial of each number in the specified collection.
    /// A collection of non-negative decimal numbers.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    decimal FindFactorial(ICollection<decimal> numbers);

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
    ICollection<int> TakeTopNumbers(ICollection<int> numbers, int count);
}
