using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();
        public void PrintInfo()
        {
            Debug.Log("this is PrintInfo method form base calss");
        }
    }
}