using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shorken : MonoBehaviour
{
    public float rotationNum = 0f;
    public float moveNum = 0;
    public bool right0left1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rotationNum += 0.5f;
        if (rotationNum == 360 * 4) {
            rotationNum = 0;
        }
        if (right0left1 == false) {
            transform.rotation = Quaternion.Euler(new Vector3(rotationNum / 4, 0, 0)); // rotation on x
        }
        if (right0left1 == true) {
            transform.rotation = Quaternion.Euler(new Vector3(-rotationNum / 4, 0, 0)); // rotation on x
        }
        if (moveNum < 9 && right0left1 == false) {
            moveNum += Time.deltaTime  * 3; 
        }
        if (moveNum > 9) {
            right0left1 = true;
            
        }
        if (moveNum > 0 && right0left1 == true) {
            moveNum -= Time.deltaTime * 3;
        }
        if (moveNum < 0) {
            right0left1 = false;
        }
        transform.position = new Vector3(transform.position.x, transform.position.y,  moveNum);
        

    }
}
