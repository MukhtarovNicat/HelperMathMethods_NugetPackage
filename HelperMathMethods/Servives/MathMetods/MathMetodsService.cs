﻿namespace HelperMathMethods.Servives.MathMetods;

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
}
