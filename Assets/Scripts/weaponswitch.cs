using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour
{
    public GameObject w;
    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public Animator a;
    public static int weapon = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && w1.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w1.SetActive(false);
            w.SetActive(true);
            weapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && w2.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w2.SetActive(false);
            w.SetActive(true);
            weapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && w3.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w3.SetActive(false);
            w.SetActive(true);
            weapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && w4.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w4.SetActive(false);
            w.SetActive(true);
            weapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && w2.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w2.SetActive(false);
            w1.SetActive(true);
            weapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && w.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w1.SetActive(true);
            w1.SetActive(false);
            weapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && w3.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w1.SetActive(true);
            w3.SetActive(false);
            weapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && w4.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w1.SetActive(true);
            weapon = 1;
            w4.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && w.active)
        {
            a.SetBool("pistol", false);
            a.SetBool("rifle", true);
            w1.SetActive(true);
            w.SetActive(false);
            weapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && w.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w2.SetActive(true);
            w.SetActive(false);
            weapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && w4.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w2.SetActive(true);
            w4.SetActive(false);
            weapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && w3.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w2.SetActive(true);
            w3.SetActive(false);
            weapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && w1.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w2.SetActive(true);
            w1.SetActive(false);
            weapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && w1.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w3.SetActive(true);
            w1.SetActive(false);
            weapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && w2.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w3.SetActive(true);
            w2.SetActive(false);
            weapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && w4.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w3.SetActive(true);
            w4.SetActive(false);
            weapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && w.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w3.SetActive(true);
            w.SetActive(false);
            weapon = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && w1.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w4.SetActive(true);
            w1.SetActive(false);
            weapon = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && w2.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w4.SetActive(true);
            w2.SetActive(false);
            weapon = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && w3.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w4.SetActive(true);
            w3.SetActive(false);
            weapon = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && w.active)
        {
            a.SetBool("rifle", false);
            a.SetBool("pistol", true);
            w4.SetActive(true);
            w.SetActive(false);
            weapon = 4;
        }
    }
}
