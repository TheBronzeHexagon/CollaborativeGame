using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Control : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position=transform.position+new Vector3(0,0,0.015f);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position=transform.position+new Vector3(0,0,-0.015f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position=transform.position+new Vector3(0.015f,0, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position=transform.position+new Vector3(-0.015f,0, 0);
        }
    }
    
}