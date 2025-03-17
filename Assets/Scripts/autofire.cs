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
    public Camera cam;
    public GameObject scar;
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
        Ray ray1 = new Ray(transform.position, transform.right * -1);
        if (Physics.Raycast(ray1, out rc, 600))
        {
            Debug.Log($"Shot fired at {rc.collider.gameObject.name}");
            Debug.DrawLine(transform.position, transform.right, Color.red, 0.3f);
            GameObject go = rc.collider.gameObject;
            if (go.tag == "RUS" || go.tag == "IDF")
            {
                Health he = go.GetComponent<Health>();
                he.health -= 41;
            }
            cammo--;
        }
        a2.SetBool("shooting", true);
        yield return new WaitForSeconds(0.06f);
        a2.SetBool("shooting", false);
        a2.StopPlayback();
        a.Play();
    }
}