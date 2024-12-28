using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class TestPart2 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            CustomObject o1 = new CustomObject("first object", 10);
            print(o1);
            CustomObject o2 = new CustomObject("second object", 20);
            print($"using != o1 , o2 Is : {(o1 != o2)} but using == o1 , o2 Is {(o1 == o2)}");
        }
    }
}