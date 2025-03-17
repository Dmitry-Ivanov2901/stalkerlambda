using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator respawn()
    {
        Debug.Log("Enemy killed");
        gameObject.SetActive(false);
        yield return new WaitForSeconds(10);
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) 
        {
             StartCoroutine(respawn());
        }
    }
}
