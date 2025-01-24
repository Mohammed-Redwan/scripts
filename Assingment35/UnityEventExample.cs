using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggered;
        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(MethodToAttachToUnityEvent);
            // onEventTriggered.Invoke();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                onEventTriggered.Invoke();
        }
        void MethodToAttachToUnityEvent()
        {
            Debug.Log("The event has been triggered!");
        }
    }
}