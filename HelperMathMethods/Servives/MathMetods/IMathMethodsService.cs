
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
}
