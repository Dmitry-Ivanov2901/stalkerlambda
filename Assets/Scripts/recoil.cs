using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class recoil : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation a;
    public Transform cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            a.Play();
            cam.Rotate(Vector3.up, 5);
            int i = new System.Random().Next(0, 1);
            if(i == 0)
            {
                cam.Rotate(Vector3.left, 5);
            }
            else
            {
                cam.Rotate(Vector3.right, 5);
            }
        }
    }
}
