using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolfire_10mm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AudioSource a;
    public Animator a2;
    public GameObject cam;
    float lf;
    int cammo = 15;
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
    // Update is called once per frame
    void Update()
    {
        GameObject hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - lf >= 0.1 && cammo >= 1)
            {
                RaycastHit rc;
                lf = Time.time;
                Ray ray1 = new Ray(transform.position, transform.right * -1);
                if (Physics.Raycast(ray1, out rc, 600))
                {
                    if (rc.collider.gameObject.GetComponent<Health>() != null)
                    {
                        StartCoroutine(rc.collider.gameObject.GetComponent<Health>().decreaseHealth10mm());
                    }
                    cammo--;
                }
                a2.SetBool("shooting", true);
                a2.SetBool("shooting", false);
                a2.StopPlayback();
                a.Play();
                cam.transform.Rotate(-3, 0, 0);
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
        yield return new WaitForSeconds(1.15f);
        a2.SetBool("reloading", false);
        cammo = 15;
    }
}
