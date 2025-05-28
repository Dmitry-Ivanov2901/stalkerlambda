using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    float dist = 75;
    GameObject target;
    bool selected;
    public bool lookAt;
    public GameObject weapon;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!selected) {
            float[] dists = new float[4];
            Collider[] cols = Physics.OverlapSphere(transform.position, dist);
            List<GameObject> enemies = new List<GameObject>();
            foreach (Collider col in cols)
            {
                if((col.gameObject.GetComponent<Health>() != null || col.gameObject.GetComponent<playerHealth>() != null) && col.gameObject.CompareTag("Friendly"))
                {
                    enemies.Add(col.gameObject);
                }
            }
            if (enemies.Count > 0)
            {
                target = enemies[new System.Random().Next(enemies.Count)];
                selected = true;
            }
        }
        else if (selected)
        {
            transform.LookAt(target.transform);
            if (lookAt)
            {
                weapon.transform.LookAt(target.transform);
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x, 0, target.transform.position.z), moveSpeed * Time.deltaTime);
        }
        if(target == null)
        {
            selected = false;
        }
    }
}
