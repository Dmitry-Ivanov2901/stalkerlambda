using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enFire : MonoBehaviour
{
    public List<GameObject> friendlies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        friendlies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Friendly"));
    }
    public float lf;
    public AudioSource fire;
    bool reloading;
    public int maxAmmo;
    int currentammo;
    // Update is called once per frame
    void Update()
    {
        RaycastHit rc ;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out rc))
        {
            if (gameObject.tag == "545")
            {
                if (Time.time - lf > 0.092f && currentammo > 0 && reloading == false && rc.collider.gameObject.tag == "Friendly")
                {
                    currentammo--;
                    Health h = rc.collider.gameObject.GetComponent<Health>();
                    h.health -= 25;
                }
            }
            if (gameObject.tag == "556")
            {
                if (Time.time - lf > 0.092f && currentammo > 0 && reloading == false && rc.collider.gameObject.tag == "Friendly")
                {
                    currentammo--;
                    Health h = rc.collider.gameObject.GetComponent<Health>();
                    h.health -= 24;
                }
            }
            if (gameObject.tag == "76239")
            {
                if (Time.time - lf > 0.092f && currentammo > 0 && reloading == false && rc.collider.gameObject.tag == "Friendly")
                {
                    currentammo--;
                    Health h = rc.collider.gameObject.GetComponent<Health>();
                    h.health -= 35;
                }
            }
            if(gameObject.tag == "76251")
            {
                if (Time.time - lf > 0.092f && currentammo > 0 && reloading == false && rc.collider.gameObject.tag == "Friendly")
                {
                    currentammo--;
                    Health h = rc.collider.gameObject.GetComponent<Health>();
                    h.health -= 50;
                }
            }
        }
    }
}
