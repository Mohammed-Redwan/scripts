using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = FibonacciRecursion(20);
        int j = FibonacciRecursion(30);
        Debug.Log(" from recursion func : 30 => " + j);
        Debug.Log(" from recursion func : 20 => " + i);

        FibonacciIterative(20);
        FibonacciIterative(30);

        
        //    Debug.Log(FibonacciIterative(5));
    }

    int FibonacciRecursion(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    }
    public void FibonacciIterative(int len)
    {
        int a = 0, b = 1, c = 0;
        
        for (int i = 2; i <= len; i++)
        {
            c = a + b;
            
            a = b;
            b = c;
        }
        Debug.Log($"from iterative func :{len} => " + c);
    }
}
