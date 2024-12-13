using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment26
{
    public class Kangaroo : Creature , IRunable , IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump() {
            Debug.Log("Kangaroo jumps.");
        }
        public  override void Speak() {
            Debug.Log("Dangaroo says: Hop!");
        }
    }
}