using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Timeline;
public class spook : MonoBehaviour
{
    public GameObject ac47;
    public GameObject minigun;
    public GameObject minigun1;
    public GameObject minigun2;
    public GameObject e;
    public GameObject m18;
    public GameObject spawn;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public AudioSource fly;
    public AudioSource fire;
    public AudioSource loop;
    public AudioSource bullet;
    public bool spooky = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireSupport.isSpook)
        {
            RaycastHit rc;
            System.Random r = new System.Random();
            Vector3 traj = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t1 = new Vector3(fireSupport.sgpos.x - r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t2 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z - r.Next(0, 900));
            Vector3 t3 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t4 = new Vector3(fireSupport.sgpos.x - r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t5 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t6 = new Vector3(fireSupport.sgpos.x - r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z - r.Next(0, 900));
            Vector3 t7 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t8 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t9 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t10 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 t11 = new Vector3(fireSupport.sgpos.x + r.Next(0, 900), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 900));
            Vector3 m1 = new Vector3(fireSupport.sgpos.x + r.Next(0, 150), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 115));
            Vector3 m2 = new Vector3(fireSupport.sgpos.x - r.Next(0, 125), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 150));
            Vector3 m3 = new Vector3(fireSupport.sgpos  .x + r.Next(0, 145), fireSupport.sgpos.y + 20, fireSupport.sgpos.z - r.Next(0, 125));
            Vector3 m4 = new Vector3(fireSupport.sgpos.x - r.Next(0, 135), fireSupport.sgpos.y + 20, fireSupport.sgpos.z - r.Next(0, 135));
            Vector3 m5 = new Vector3(fireSupport.sgpos.x + r.Next(0, 116), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 147));
            Vector3 m6 = new Vector3(fireSupport.sgpos.x + r.Next(0, 126), fireSupport.sgpos.y + 20, fireSupport.sgpos.z + r.Next(0, 117));
            Vector2 origin = new Vector3(fireSupport.sgpos.x, fireSupport.sgpos .y + 20, fireSupport.sgpos.z);
            Ray ray = new Ray(origin, traj);
            Ray r1 = new Ray(m1, t1);
            Ray r2 = new Ray(m6, t10);
            Ray r3 = new Ray(m2, t2);
            Ray r4 = new Ray(m3, t3);
            Ray r5 = new Ray(m4, t4);
            Ray r6 = new Ray(m5, t5);
            Ray r7 = new Ray(origin, t6);
            Ray r8 = new Ray(origin, t7);
            Ray r9 = new Ray(origin, t8);
            Ray r10 = new Ray(origin, t9);
            Ray r11 = new Ray(origin, t10);
            Ray r12 = new Ray(origin, t11);
            Debug.DrawLine(ray.origin, ray.direction, Color.red);
            Debug.DrawLine(r1.origin, r1.direction, Color.red);
            Debug.DrawLine(r2.origin, r2.direction, Color.red);
            Debug.DrawLine(r3.origin, r3.direction, Color.red);
            Debug.DrawLine(r4.origin, r4.direction, Color.red);
            Debug.DrawLine(r5.origin, r5.direction, Color.red);
            Debug.DrawLine(r6.origin, r6.direction, Color.red);
            Debug.DrawLine(r7.origin, r7.direction, Color.red);
            Debug.DrawLine(r8.origin, r8.direction, Color.red);
            Debug.DrawLine(r9.origin, r9.direction, Color.red);
            Debug.DrawLine(r10.origin, r10.direction, Color.red);
            Debug.DrawLine(r11.origin, r11.direction, Color.red);
            Debug.DrawLine(r12.origin, r12.direction, Color.red);
            if (Physics.Raycast(ray, out rc) || Physics.Raycast(r11, out rc) || Physics.Raycast(r12, out rc) || Physics.Raycast(r8, out rc) || Physics.Raycast(r9, out rc) || Physics.Raycast(r10, out rc) || Physics.Raycast(r1, out rc) || Physics.Raycast(r2, out rc) || Physics.Raycast(r3, out rc) || Physics.Raycast(r4, out rc) || Physics.Raycast(r5, out rc) || Physics.Raycast(r6, out rc) || Physics.Raycast(r7, out rc))
            {
                Debug.Log("20mm hit" + rc.transform.name);
                if (rc.transform.gameObject.layer == 7 || rc.transform.gameObject.tag == e.tag)
                {
                    delay();
                    rc.transform.gameObject.SetActive(false);
                    GameObject rs = Instantiate(rc.transform.gameObject, spawn.transform.position, Quaternion.identity);
                    rc.transform.gameObject.SetActive(true);
                    Debug.Log("spookkill");
                    
                    int ra = r.Next(0, 3);
                    if(ra == 0)
                    {
                        rc.collider.gameObject.transform.position = spawn.transform.position;
                    }
                    else if (ra == 1)
                    {
                        rc.collider.gameObject.transform.position = spawn2.transform.position;
                    }
                    else if (ra == 2)
                    {
                        rc.collider.gameObject.transform.position = spawn3.transform.position;
                    }
                    else if (ra == 3)
                    {
                        rc.collider.gameObject.transform.position = spawn4.transform.position;
                    }
                }
            }
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(5);
    }
}
