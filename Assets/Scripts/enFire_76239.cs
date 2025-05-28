using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enFire_76239 : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
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
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lf >= 0.1f && currentammo >= 1)
        {
            lf = Time.time;
            RaycastHit rc;
            Ray ray = new Ray(transform.position, transform.right);
            System.Random r = new System.Random();
            if (Physics.Raycast(ray, out rc))
            {
                int hitChance = r.Next(10);
                if (rc.collider.gameObject.GetComponent<playerHealth>() != null && hitChance == 1 && rc.distance <= 35)
                {
                    fire.Play();
                    currentammo--;
                    Debug.Log("THE PLAYER HAS BEEN HIT");
                    StartCoroutine(rc.collider.gameObject.GetComponent<playerHealth>().decreaseHealth76239());
                }
                if (rc.collider.gameObject.GetComponent<Health>() != null && hitChance == 1 && rc.collider.CompareTag("Friendly") && rc.distance <= 35)
                {
                    fire.Play();
                    currentammo--;
                    StartCoroutine(rc.collider.gameObject.GetComponent<Health>().decreaseHealth76239());
                }
            }
        }
        if (currentammo == 0 && !reloading)
        {
            StartCoroutine(reload());
        }
    }
}
