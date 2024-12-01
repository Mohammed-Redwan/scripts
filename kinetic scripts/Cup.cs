using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEditor.Rendering;
using UnityEditor.Rendering.BuiltIn.ShaderGraph;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public float arrayTimer = 0;
    public float timer = 0;
    public float varScale = 0;
    public float angular = 0;
    public bool big0small1 = false; 
    public bool startAction = false;
    // Start is called before the first frame update
    void Start()
    {
        varScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (arrayTimer < 100 && timer < 100) {
            arrayTimer += Time.deltaTime;  
            timer += Time.deltaTime;
        }
        
        if (arrayTimer > 0 && timer > 1) {
            startAction = true;
        }

        if (startAction == true) {
            varScale = Mathf.Sin(angular * Mathf.Deg2Rad * 4);
            transform.localScale = new Vector3(varScale + 2, varScale + 2, varScale + 2);
            if (angular < 180 && big0small1 == false) {
                angular += Time.deltaTime * 15;
            }
            
            if (angular > 180 && big0small1 == false) {
                big0small1 = true;
            }
            if (angular > 0 && big0small1 == true) {
                angular -= Time.deltaTime * 15;
            }
            if (angular < 0 && big0small1 == true) {
                big0small1 = false;
            }
        }
            
        
    }
}
