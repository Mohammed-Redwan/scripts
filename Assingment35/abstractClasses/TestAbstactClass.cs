using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAbstactClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DrivedClassExample ex1 = new DrivedClassExample();
        ex1.PerformAction();
        ex1.PrintInfo();
    }
}
