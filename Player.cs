using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B)) {
            transform.position += new Vector3(-Time.deltaTime * 2f, 0, 0);
            Debug.Log("Boosted");
        }

        if (Input.GetAxisRaw("Vertical") < 0) {
            transform.position += new Vector3(Time.deltaTime * 4f, 0, 0);
        }

        
        if (Input.GetAxisRaw("Vertical") > 0) {
            transform.position += new Vector3(-Time.deltaTime * 4f, 0, 0);
        }
        
    }
}
