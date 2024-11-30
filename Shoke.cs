using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoke : MonoBehaviour
{
    
    public bool up0down1 = false;
    public float shokeMoveNum = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (up0down1 == false && shokeMoveNum < 3) {
            shokeMoveNum += Time.deltaTime * 3;
            transform.position = new Vector3(transform.position.x, shokeMoveNum, transform.position.z);
        } 
        if (shokeMoveNum > 3 ) {
            up0down1 = true;

        }

        if (up0down1 == true && shokeMoveNum > -0.33f) {
            shokeMoveNum -= Time.deltaTime * 3;
            transform.position = new Vector3(transform.position.x, shokeMoveNum, transform.position.z);
            
        }

        if (shokeMoveNum < -0.33f) {
            up0down1 = false;
        }
    }
}
