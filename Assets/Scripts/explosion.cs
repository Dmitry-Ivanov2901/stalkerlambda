using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject area;
    public GameObject bomb;
    public GameObject sprite;
    AudioSource a;
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
            a.Play();
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
