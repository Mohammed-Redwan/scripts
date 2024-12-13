using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class Ass27 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int firstInt = 1;
            int secondInt = 2;
            int outArg;

            Debug.Log(FirstFun(firstInt));
            Debug.Log(firstInt);
            Debug.Log("====================");
            Debug.Log(SecondFun(ref secondInt));
            Debug.Log(secondInt);
            Debug.Log("====================");
            Debug.Log(OutFun(out outArg));
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        int FirstFun(int var1) {
            var1 += 10;
            return var1;
        }
        int SecondFun(ref int var2) {
            var2 += 10;
            return var2;
        }
         int OutFun(out int outparam) {
            outparam = 3;
            return outparam;
        }
    }
}