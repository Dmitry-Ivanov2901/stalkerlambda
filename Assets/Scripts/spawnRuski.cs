using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRuski : MonoBehaviour
{
    public GameObject spawn;
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Instantiate(gameObject, spawn.transform, spawn.transform);
        go.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(go.activeInHierarchy == false)
        {
        }
    }
}
