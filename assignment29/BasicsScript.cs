using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace assignment29
{

    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            var intg = 10;
            var booln = true;
            var strng = "string";
            booln = ((intg % 2) == 0) ? true : false;
            if (booln)
            {
                Debug.Log("the number is even");
            }
            else
            {
                Debug.Log("the number is odd");
            }
            CustomObject o1 = new CustomObject("falsj;kd", 23);
            CustomObject o2 = new CustomObject("s;lkd;lkdsjkfds;lkfds;kd", 23);
            Debug.Log("o1 and o2 not equals ?"  + (o1 != o2)) ;
            Debug.Log("date: " + DateTime.Now.Date);
            Debug.Log("time: " + DateTime.Now.TimeOfDay);
            Debug.Log("day: " + DateTime.Now.Day + " / " + DateTime.Now.DayOfWeek);

        }
    

    }
}