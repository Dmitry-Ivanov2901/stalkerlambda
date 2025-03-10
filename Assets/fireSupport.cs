using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class fireSupport : MonoBehaviour
{
    public AudioSource puff;
    public AudioSource ro;
    public AudioSource houfnice;
    public AudioSource art;
    public GameObject ac47;
    public GameObject minigun;
    public GameObject minigun1;
    public GameObject minigun2;
    public GameObject tamale;
    public GameObject spook;
    public AudioSource artycall;
    public AudioSource artyaffirm;
    public GameObject arty;
    public GameObject wparty;
    public AudioSource aus;
    public AudioSource request;
    public LayerMask worldLayer;
    public static Vector3 location;
    public GameObject m18;
    public static Vector3 sgpos;
    public AudioSource affirm;
    public static bool isSpook = false;
    public GameObject f4;
    GameObject plane;
    public GameObject dima;
    public AudioSource exp;
    public AudioSource flyby;
    public float velocity = 2.370f;
    public GameObject blu1;
    public Vector3 mark;
    public bool napalm = false;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {

    }
    //The following function is not mine
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (menu.activeInHierarchy)
            {
                menu.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
            }
        }
    }
    IEnumerator after()
    {
        yield return new WaitForSeconds(3);
        napalm = false;
    }
    IEnumerator nape()
    {
        RaycastHit hitInfo;

        Vector3 mousePosition = Input.mousePosition;

        Ray rayOrigin = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            napalm = true;
            request.Play();
            yield return new WaitForSeconds(11);
            affirm.Play();
            float pz = hitInfo.point.z + 100;
            Debug.Log("Raycast hit object " + hitInfo.transform.name + " at the position of " + hitInfo.point);
            location = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);
            Vector3 bl = new Vector3(hitInfo.point.x, hitInfo.point.y + 100, hitInfo.point.z);
            Vector3 bl1 = new Vector3(hitInfo.point.x, hitInfo.point.y + 100, hitInfo.point.z + 50);
            Vector3 planpos = new Vector3(hitInfo.point.x, hitInfo.point.y + 100, -pz);
            Vector3 movetowards = new Vector3(hitInfo.point.x, hitInfo.point.y + 100, hitInfo.point.z - 50000);
            Vector3 bombpos = new Vector3(planpos.x, planpos.y - 20, planpos.z);
            yield return new WaitForSeconds(9);
            GameObject plane = Instantiate(tamale, planpos, Quaternion.identity);
            plane.SetActive(true);
            Rigidbody prb = plane.AddComponent<Rigidbody>();
            prb.useGravity = false;
            prb.AddForce(0, 0, 3000);
            flyby.Play();
            GameObject bomb = Instantiate(blu1, bombpos, Quaternion.identity);
            GameObject bomb1 = Instantiate(blu1, bombpos, Quaternion.identity);
            yield return new WaitForSeconds(6f);
            Destroy(bomb);
            Destroy(bomb1);
            yield return new WaitForSeconds(10);
            Destroy(plane);
        }
    }
    IEnumerator spooky()
    {
        puff.Play();
        yield return new WaitForSeconds(9);
        ro.Play();
        yield return new WaitForSeconds(6);
        isSpook = true;
        RaycastHit hitInfo;

        Vector3 mousePosition = Input.mousePosition;

        Ray rayOrigin = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            Debug.Log("Raycast hit object " + hitInfo.transform.name + " at the position of " + hitInfo.point);
            GameObject sg = Instantiate(m18, hitInfo.point, Quaternion.identity);
            sgpos = sg.transform.position;
            location = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);
            Vector3 planpos = new Vector3(hitInfo.point.x + 100, hitInfo.point.y + 100, hitInfo.point.z);
            GameObject plane = Instantiate(ac47, planpos, Quaternion.identity);
        }
        yield return new WaitForSeconds(60);
        fireSupport.isSpook = false;
    }
    IEnumerator artillery()
    {
        RaycastHit rc = new RaycastHit();
        float zpos = -mark.z;
        Ray rayOrigin = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(rayOrigin, out rc))
        {
            artyaffirm.Play();
            yield return new WaitForSeconds(5);
            artycall.Play();
            Vector3 premark = rc.point;
            mark = new Vector3(premark.x, premark.y + 100, premark.z);
            Vector3 mark2 = new Vector3(premark.x + 10, premark.y + 100, premark.z);
            Vector3 mark3 = new Vector3(premark.x + 15, premark.y + 100, premark.z + 15);
            Vector3 mark4 = new Vector3(premark.x + 25, premark.y + 100, premark.z + 15);
            Vector3 mark5 = new Vector3(premark.x + 15, premark.y + 100, premark.z + 22);
            houfnice.Play();
            art.Play();
            Debug.Log("Called artillery");
            GameObject bomb = Instantiate(arty, mark, arty.transform.rotation);
            bomb.SetActive(true);
            GameObject bomb1 = Instantiate(wparty, mark2, wparty.transform.rotation);
            bomb1.SetActive(true);
            yield return new WaitForSeconds(3);
            GameObject b = Instantiate(arty, mark3, arty.transform.rotation);
            b.SetActive(true);
            GameObject b1 = Instantiate(wparty, mark3, wparty.transform.rotation);
            b1.SetActive(true);
            yield return new WaitForSeconds(3);
            GameObject b2 = Instantiate(arty, mark2, arty.transform.rotation);
            b2.SetActive(true);
            GameObject b3 = Instantiate(wparty, mark3, wparty.transform.rotation);
            b3.SetActive(true);
            yield return new WaitForSeconds(3);
            GameObject b4 = Instantiate(arty, mark4, arty.transform.rotation);
            b4.SetActive(true);
            GameObject b5 = Instantiate(wparty, mark5, wparty.transform.rotation);
            b5.SetActive(true);
            art.Stop();
            houfnice.Stop();
        }
    }
}
