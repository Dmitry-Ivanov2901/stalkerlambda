using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRuski : MonoBehaviour
{
    public GameObject enemy;
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Instantiate(enemy, gameObject.transform, gameObject.transform);
        go.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(go.activeInHierarchy == false)
        {
            StartCoroutine(respawn());
        }
    }
    IEnumerator respawn()
    {
        yield return new WaitForSeconds(15);
        go = GameObject.Instantiate(enemy);
        go.SetActive(true);
    }
}
