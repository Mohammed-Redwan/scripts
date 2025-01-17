using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
namespace PhysicsBaseCharacter
{
    public class RotationScript : MonoBehaviour
    {
        // Start is called before the first frame update
        
        Rigidbody capsuleBody;
        float mouseInputX;
        float mouseInputY;
        public float sensitevity;
        float xrotation;
        float yrotation;
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            // cameraBody = GetComponent<Rigidbody>();
            capsuleBody = transform.parent.GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
            mouseInputX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitevity * 100;
            mouseInputY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitevity * 100;
            xrotation += -mouseInputY;
            yrotation += mouseInputX;
            xrotation = Mathf.Clamp(xrotation, -40f , 90f);
            transform.rotation = Quaternion.Euler(xrotation, yrotation, 0);
            // transform.parent.rotation =  Quaternion.Euler(0, yrotation, 0);

        }
        private void FixedUpdate() {
            // cameraBody.rotation = Quaternion.Euler(xrotation, yrotation, 0);
            capsuleBody.rotation = Quaternion.Euler(0, yrotation, 0);
        }
    }
}