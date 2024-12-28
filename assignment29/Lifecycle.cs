using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
namespace assignment29
{
    public class Lifecycle : MonoBehaviour
    {
        public GameObject target;
        public GameObject joker;
        public Light light;
        // Start is called before the first frame update
        void OnEnable()
        {
            print("gameObject enabled");
        }
        void Start()
        {
            print("game started");
            light = GameObject.FindObjectOfType<Light>();
            joker = GameObject.FindGameObjectWithTag("Joker");
            if (light != null)
            {
                print(light.name);
            }
            else
            {
                print("no light found");
            }
            if(joker != null)
            {
                print(joker.name);
            }
            else 
            {
                print("no joker in the game!");
            }

            target = GameObject.Find("TargetObject");
            if(target != null)
            {
                Debug.Log("TargetObject found");
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if(target != null)
                {
                    print("target deactive");
                    target.SetActive(false);
                }
                else
                {
                    print("target not found");
                }
            }
        }
        private void OnDisable()
        {
            print("gameObject disabled");
        }
    }
}