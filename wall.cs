using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public float movement = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Mathf.PingPong(100, 4);
        Debug.Log(movement);
        transform.position = new Vector3(transform.position.x, transform.position.y, movement);
    }
}