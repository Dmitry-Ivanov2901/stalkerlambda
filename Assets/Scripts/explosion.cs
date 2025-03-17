using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject sprite;
    AudioSource a;
    public static bool exploded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void explode()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 9)
        {
            exploded = true;
            a.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
