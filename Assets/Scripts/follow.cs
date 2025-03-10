using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tar;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(tar.transform);
        transform.position = Vector3.MoveTowards(transform.position, tar.transform.position, 0.005f);
    }
}
