using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject sprite;
    public GameObject napalmsprite;
    public AudioSource a;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            GameObject spr = GameObject.Instantiate(sprite, transform.position, transform.rotation);
            GameObject _spr = GameObject.Instantiate(napalmsprite, transform.position, transform.rotation);
            spr.SetActive(true);
            _spr.SetActive(true);
            a.Play();
            StartCoroutine(explode());
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator explode()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider col in cols) 
        {
            Health h = col.GetComponent<Health>();
            if (h != null)
            {
                Debug.Log("Fire support kill");
                StartCoroutine(h.respawn());
            }
        }
        yield return new WaitForSeconds(0.5f);
        GameObject.Destroy(gameObject);
    }
}
