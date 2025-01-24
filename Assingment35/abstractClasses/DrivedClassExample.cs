using System.Collections;
using System.Collections.Generic;
using Assignment35;
using UnityEngine;

public class DrivedClassExample : AbstractBaseClass
{
    public override void PerformAction()
    {
        Debug.Log("this is PerformAction method from DrivedClass");
    }
}
