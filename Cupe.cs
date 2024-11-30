using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupe : MonoBehaviour
{
    public bool jumpBool = false;

    public float originalY = 0;
    public float currentY = 0;
    public float inc = 0;

    // Start is called before the first frame update
    void Start()
    {
        originalY = (float)transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += new Vector3(0, 0, Time.deltaTime);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += new Vector3(0, 0, -Time.deltaTime);
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpBool = true;
            
        }


        

        if (jumpBool == true)
        {
            inc += Time.deltaTime * 180;
            currentY = Mathf.Sin((inc) * Mathf.Deg2Rad);
            
            transform.position = new Vector3(transform.position.x, currentY, transform.position.z);
            if (inc > 180 && currentY < originalY)  {
                inc = 0;
                jumpBool = false;
            }
        }


    }
}
