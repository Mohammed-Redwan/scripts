using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Assignment35
{
    public class BuildInDelegateExample : MonoBehaviour
    {
        Action logMassage;
        Func<int, int> square;
        Predicate<int> isEven;
        void Start()
        {
            // logMassage = PrintString;
            logMassage = () => Debug.Log("Hello from Action delegate!");
            logMassage.Invoke();

            square = (int num) => (int)math.pow(num, 2);
            Debug.Log("result of Func square : " + square.Invoke(5));

            isEven = (int num) => (num % 2 == 0) ? true : false;
            Debug.Log("Is 4 Even? " + isEven.Invoke(4));
        }
        // void PrintString() => Debug.Log("Hello from Action delegate!");
    }
}