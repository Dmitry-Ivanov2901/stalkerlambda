using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolfire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AudioSource a;
    public Animation an;
    public Animator a2;
    float lf;
    int cammo = 8;
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
                Ray ray1 = new Ray(transform.position, transform.forward);
                a2.Play("fire");
                a.Play();
                if (Physics.Raycast(ray1, out rc))
                {
                    GameObject go = rc.collider.gameObject;
                    if (go.layer == 10)
                    {
                        enemies e = ens.Find(x => x.name == go.name);
                        e.hp -= 41;
                    }
                }
                cammo--;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reload());
        }
    }
    IEnumerator reload()
    {
        a2.Play("reload");
        yield return new WaitForSeconds(1.15f);
        cammo = 8;
    }
}
