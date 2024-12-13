using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound");
        }
    }
}