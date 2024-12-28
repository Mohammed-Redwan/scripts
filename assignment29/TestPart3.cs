using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment29
{
    public class TestPart3 : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("test utl add method " + Utilities.Add(1, 2, 3, 4, 5));
            string repeatedText = Utilities.RepeatString("mohammed", 2);
            Debug.Log("test utl repeat string method : " + repeatedText);
        }
    }
}