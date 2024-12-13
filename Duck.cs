using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment26
{
    public class Duck : Creature , IRunable , ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }
}