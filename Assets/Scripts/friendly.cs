using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class friendly : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> enemies = new List<GameObject>();
    public float moveSpeed;
    float dist = 75;
    GameObject target;
    bool selected;
    public GameObject player;
    public GameObject weapon;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, dist);
        List<GameObject> enemies = new List<GameObject>();
        foreach (Collider col in cols)
        {
            if (col.gameObject.GetComponent<Health>() != null && col.gameObject.CompareTag("enemy"))
            {
                enemies.Add(col.gameObject);
            }
        }
        if (enemies.Count > 0)
        {
            if (!selected)
            {
                if (enemies.Count > 0)
                {
                    target = enemies[new System.Random().Next(enemies.Count)];
                    selected = true;
                }
            }
            else if (selected)
            {
                float distance = Vector3.Distance(target.transform.position, transform.position);
                if (distance >= 5)
                {
                    transform.LookAt(target.transform);
                    weapon.transform.LookAt(target.transform);
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x, 0, target.transform.position.z), moveSpeed * Time.deltaTime);
                }
            }
            if (target == null)
            {
                selected = false;
            }
        }
        else
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance >= 5)
            {
                transform.LookAt(player.transform);
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 0, player.transform.position.z), moveSpeed * Time.deltaTime);
            }
        }
    }
}
