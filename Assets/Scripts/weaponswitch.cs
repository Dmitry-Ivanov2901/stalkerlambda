using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour
{
    public GameObject m18;
    public GameObject ak15;
    public GameObject scar;
    public GameObject m45;
    public GameObject sr1;
    public GameObject tt33;
    public GameObject g3a3;
    public GameObject chukavin;
    GameObject curWep;
    public Animator an;
    // Start is called before the first frame update
    void Start()
    {
        an.Play("akhold");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            curWep.SetActive(false);
            ak15.SetActive(true);
            curWep = ak15;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            curWep.SetActive(false);
            scar.SetActive(true);
            curWep = scar;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            curWep.SetActive(false);
            an.Play("pistolhold");
            tt33.SetActive(true);
            curWep = tt33;
        }
    }
}
