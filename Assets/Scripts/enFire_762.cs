using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enFire_762 : MonoBehaviour
{
    public List<GameObject> friendlies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        friendlies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Friendly"));
        currentammo = maxAmmo;
        reloading = false;
    }
    float lf;
    public AudioSource fire;
    public bool reloading;
    public int maxAmmo;
    public int currentammo;
    float t;
    IEnumerator reload()
    {
        reloading = true;
        yield return new WaitForSeconds(3);
        currentammo = 30;
    }
    IEnumerator shoot()
    {
        RaycastHit rc;
        Ray ray = new Ray(transform.position, transform.forward * -1);
        System.Random r = new System.Random();
        if (Physics.Raycast(ray, out rc))
        {
            lf = Time.time;
            int hitChance = r.Next(10);
            if (rc.collider.gameObject.GetComponent<playerHealth>() != null && hitChance == 1)
            {
                fire.Play();
                currentammo--;
                Debug.Log("THE PLAYER HAS BEEN HIT");
                StartCoroutine(rc.collider.gameObject.GetComponent<playerHealth>().decreaseHealth545());
            }
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lf >= 0.1 && currentammo >= 1)
        {
            RaycastHit rc;
            Ray ray = new Ray(transform.position, transform.forward * -1);
            System.Random r = new System.Random();
            if (Physics.Raycast(ray, out rc))
            {
                lf = Time.time;
                int hitChance = r.Next(10);
                if (rc.collider.gameObject.GetComponent<playerHealth>() != null && hitChance == 1)
                {
                    fire.Play();
                    currentammo--;
                    Debug.Log("THE PLAYER HAS BEEN HIT");
                    StartCoroutine(rc.collider.gameObject.GetComponent<playerHealth>().decreaseHealth76251());
                }
                if (rc.collider.gameObject.GetComponent<Health>() != null && hitChance == 1)
                {
                    fire.Play();
                    currentammo--;
                    StartCoroutine(rc.collider.gameObject.GetComponent<Health>().decreaseHealth545());
                }
            }
        }
        if (currentammo == 0 && !reloading)
        {
            StartCoroutine(reload());
        }
    }
}
