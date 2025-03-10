using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autofire : MonoBehaviour
{
    public AudioSource a;
    public Animation an;
    public Animator a2;
    float lf;
    public int cammo = 30;
    struct enemies
    {
        public string name;
        public int hp;
        public GameObject body;
    }
    List<enemies> ens;
    List<GameObject> getObjectByLayer(int layer)
    {
        UnityEngine.Object[] objects = Resources.FindObjectsOfTypeAll<GameObject>();
        List<GameObject> list = new List<GameObject>();
        foreach (GameObject obj in objects)
        {
            if (obj.layer == layer)
            {
                list.Add(obj);
            }
        }
        return list;
    }
    void Start()
    {
        int i = 0;
        List<GameObject> en = getObjectByLayer(10);
        foreach (GameObject e in en)
        {
            if (e.layer == 10)
            {
                enemies c = new enemies();
                c.name = e.name;
                c.body = e.gameObject;
                c.hp = 100;
                ens.Add(c);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        GameObject hit;
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lf >= 0.1 && cammo >= 1)
            {
                StartCoroutine(shoot());
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reload());
        }
    }
    IEnumerator reload()
    {
        a2.SetBool("reloading", true);
        yield return new WaitForSeconds(1.24f);
        a2.SetBool("reloading", false);
        a2.StopPlayback();
        cammo = 30;
    }
    IEnumerator shoot()
    {
        RaycastHit rc;
        lf = Time.time;
        Ray ray1 = new Ray(transform.position, transform.forward);
        a2.SetBool("shooting", true);
        yield return new WaitForSeconds(0.06f);
        a2.SetBool("shooting", false);
        a2.StopPlayback();
        a.Play();
        if (Physics.Raycast(ray1, out rc))
        {
            GameObject go = rc.collider.gameObject;
            if (go.layer == 10)
            {
                enemies e = ens.Find(x => x.name == go.name);
                e.hp -= 41;
            }
            cammo--;
        }
    }
}