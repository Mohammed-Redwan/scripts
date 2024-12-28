using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class ExceptionPart : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int playerScore = 100;
            int diviser = 0;
            try
            {
                Debug.Log( "attempting to divide 100 by zero");
                int result = playerScore / diviser;
                
            } catch (DivideByZeroException e)
            {
                Debug.LogError("divide by zero error!");
            }
            finally
            {
                Debug.Log("Score calculation coptete. Cleaning up resoursces");
            }


        }

    }
}