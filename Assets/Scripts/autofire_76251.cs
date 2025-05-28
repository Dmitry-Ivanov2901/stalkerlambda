using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autofire_76251 : MonoBehaviour
{
    public AudioSource a;
    public Animation an;
    public Animator a2;
    float lf;
    public int cammo = 20;
    public GameObject cam;
    public GameObject scar;
    bool reloading = false;
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
        reloading = true;
        a2.SetBool("reloading", true);
        yield return new WaitForSeconds(1.24f);
        a2.SetBool("reloading", false);
        a2.StopPlayback();
        cammo = 20;
        reloading = false;
    }
    IEnumerator shoot()
    {
        RaycastHit rc; 
        lf = Time.time;
        Ray ray1 = new Ray(transform.position, transform.right * -1);
        if (Physics.Raycast(ray1, out rc, 600) && !reloading)
        {
            if (rc.collider.gameObject.GetComponent<Health>() != null)
            {
                StartCoroutine(rc.collider.gameObject.GetComponent<Health>().decreaseHealth76251());
            }
        }
        a2.SetBool("shooting", true);
        yield return new WaitForSeconds(0.1f);
        a2.SetBool("shooting", false);
        a2.StopPlayback();
        a.Play();
        cam.transform.Rotate(-2.5f, 0, 0);
        cammo--;
    }
    IEnumerator respawn(GameObject go, GameObject spawn)
    {
        Debug.Log("Enemy killed");
        go.SetActive(false);
        yield return new WaitForSeconds(20);
        go.SetActive(true);
        go.transform.position = spawn.transform.position;
    }
}