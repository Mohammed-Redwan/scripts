using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.Mathematics;
using UnityEngine;
namespace Assignment35
{
    public delegate void MahtOperation(int num);
    public class MulticastDelegateExample : MonoBehaviour
    {
        public MahtOperation operation;
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation.Invoke(5);
        }
        void DoubleNumber(int num) => Debug.Log(num * 2);
        void SquareNumber(int num) => Debug.Log(math.pow(num, 2));
        void CubeNumber(int num) => Debug.Log(math.pow(num, 3));


    }
}