using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class MethodChainging : MonoBehaviour
    {
        
        void Start()
        {
           SetPosition(transform.position + new Vector3(0,1,0))
           .SetRotation(new Vector3(45, 0, 0))
           .SetScale(new Vector3(2, 2, 2));

        }

        public MethodChainging SetPosition(Vector3 newPosition)
        {
            transform.position = newPosition;
            return this;
        }
        public MethodChainging SetRotation(Vector3 newRotation)
        {
            transform.rotation = Quaternion.Euler(newRotation);
            return this;
        }
        public MethodChainging SetScale(Vector3 newScale)
        {
            transform.localScale = newScale;
            return this;
        }
    }



}