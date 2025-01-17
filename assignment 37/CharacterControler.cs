using System.Collections;
using System.Collections.Generic;
using System.Data;
using ass16;
using TMPro;
using Unity.Entities.UniversalDelegates;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    int timeOfJump = 0;
    bool CollisionEnter;
    Rigidbody thisBody;
    public float speed = 7f;
    float inputZ;
    float inputX;
    Vector3 normalizedInputs;
    bool doJump;

    
    // Start is called before         
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        {
            
        }

        thisBody = GetComponent<Rigidbody>();
        thisBody.useGravity = true;
        thisBody.freezeRotation = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            
           Debug.Log("ctrl pressed speed up");
            speed += 5;

        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Debug.Log("ctrl up normal speed");
            speed -= 5;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // doJump = true;
            // CollisionEnter = false;
            if (timeOfJump < 2)
            {
                doJump = true;
            }
            else
            {
                doJump = false;
            }
            timeOfJump++;
        }        
        
        // inputZ = Input.GetAxisRaw("Vertical");
        // inputX = Input.GetAxisRaw("Horizontal");
        // normalizedInputs = new Vector3(inputX, 0, inputZ).normalized * speed;

        // normalizedInputs.y = thisBody.velocity.y;
        // Camera.main.transform.LookAt(transform);
    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            thisBody.MovePosition(transform.position + (transform.right * Time.deltaTime * speed));
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            thisBody.MovePosition(transform.position + -transform.right * Time.deltaTime * speed);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            thisBody.MovePosition(transform.position + (transform.forward * Time.deltaTime * speed));
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            thisBody.MovePosition(transform.position + -transform.forward * Time.deltaTime * speed);
        }

        // thisBody.velocity = normalizedInputs;

        // thisBody.velocity += new Vector3(0, -1f, 0);
        if (doJump)
        {
            DoJump();
            doJump = false;
        }
        

    }
    void DoJump()
    {
        thisBody.AddForce(transform.up * 5, ForceMode.Impulse);

    }
    void OnCollisionEnter()
    {
        timeOfJump = 0;
        // CollisionEnter = true;
    }
    // private void OnCollisionExit(Collision other) {
    //     CollisionEnter = false;
    // }
}
