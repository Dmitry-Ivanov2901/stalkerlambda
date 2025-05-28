using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendlyFire_556 : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
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
        if (Time.time - lf >= 0.092 && currentammo >= 1)
        {
            lf = Time.time;
            RaycastHit rc;
            Ray ray = new Ray(transform.position, transform.forward);
            System.Random r = new System.Random();
            if (Physics.Raycast(ray, out rc))
            {
                int hitChance = r.Next(5);
                if (rc.collider.gameObject.GetComponent<Health>() != null && hitChance == 1 && rc.collider.gameObject.CompareTag("enemy"))
                {
                    Debug.Log($"{rc.collider.gameObject.name} has been hit by {gameObject.name}");
                    fire.Play();
                    currentammo--;
                    StartCoroutine(rc.collider.gameObject.GetComponent<Health>().decreaseHealth556());
                }
            }
        }
        if (currentammo == 0 && !reloading)
        {
            StartCoroutine(reload());
        }
    }
}
