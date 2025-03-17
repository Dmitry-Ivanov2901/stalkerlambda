using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 10 && collision.gameObject.GetComponent("Health") != null && explosion.exploded)
        {
            collision.gameObject.SetActive(false);
        }
    }
    IEnumerator remove()
    {
        yield return new WaitForSeconds(0.1f);
    }
        // Update is called once per frame
    void Update()
    {
        if (explosion.exploded)
        {
            StartCoroutine(remove());
        }
    }
}
