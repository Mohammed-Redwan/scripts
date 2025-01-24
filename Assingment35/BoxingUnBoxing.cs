using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnBoxing : MonoBehaviour
    {
        // Start is called before the first frame update
        int health = 100;

        void Start()
        {
            object boxingHealth = health;
            int unboxingHealth = (int)boxingHealth - 30;
            Debug.Log($"original int {health} after boxing {boxingHealth} after unboxing and modifying {unboxingHealth}");

        
    }

        // Update is called once per frame
        void Update()
        {

        }
    }
}