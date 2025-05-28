using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class fireSupport : MonoBehaviour
{
    public GameObject rifle;
    public AudioSource rocketExplosion;
    public AudioSource ro;
    public AudioSource houfnice;
    public AudioSource art;
    public GameObject SSD;
    public AudioSource rocketRequest;
    public AudioSource rocketConfirmation;
    public AudioSource rocketFiring;
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
    public AudioSource approach;
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
            StartCoroutine(artillery());
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            StartCoroutine(nape());
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine(SSD75());
        }
        if (isSpook)
        {

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

        Ray rayOrigin = new Ray(rifle.transform.position, rifle.transform.forward);

        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            Debug.Log("Called napalm.");
            GameObject sg = Instantiate(m18, hitInfo.point, Quaternion.identity);
            sgpos = sg.transform.position;
            napalm = true;
            request.Play();
            yield return new WaitForSeconds(11);
            affirm.Play();
            float pz = hitInfo.point.z + 100;
            Debug.Log("Raycast hit object " + hitInfo.transform.name + " at the position of " + hitInfo.point);
            location = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);
            Vector3 bl = new Vector3(hitInfo.point.x, hitInfo.point.y + 250, hitInfo.point.z);
            Vector3 bl1 = new Vector3(hitInfo.point.x, hitInfo.point.y + 250, hitInfo.point.z + 50);
            Vector3 planpos = new Vector3(hitInfo.point.x, hitInfo.point.y + 250, hitInfo.point.z + 200);
            Vector3 movetowards = new Vector3(hitInfo.point.x, hitInfo.point.y + 250, hitInfo.point.z - 50000);
            Vector3 bombpos = new Vector3(planpos.x, planpos.y - 20, planpos.z);
            yield return new WaitForSeconds(9);
            GameObject plane = Instantiate(tamale, planpos, Quaternion.identity);
            plane.SetActive(true);
            Rigidbody prb = plane.AddComponent<Rigidbody>();
            prb.useGravity = false;
            plane.transform.LookAt(movetowards);
            plane.transform.position = Vector3.MoveTowards(plane.transform.position, movetowards, 300);
            plane.GetComponent<Rigidbody>().AddForce(0, 0, 3000);
            approach.Play();
            yield return new WaitForSeconds(3);
            flyby.Play();
            GameObject bomb = Instantiate(blu1, bl, Quaternion.identity);
            GameObject bomb1 = Instantiate(blu1, bl1, Quaternion.identity);
            bomb.SetActive(true);
            bomb1.SetActive(true);
            yield return new WaitForSeconds(11);
            Destroy(plane);
        }
    }
    IEnumerator SSD75()
    {
        RaycastHit hitInfo;

        Ray rog = new Ray(rifle.transform.position, rifle.transform.forward);

        if (Physics.Raycast(rog, out hitInfo))
        {
            Vector3 precision = new Vector3(hitInfo.point.x, hitInfo.point.y + 250, hitInfo.point.z);
            rocketRequest.Play();
            yield return new WaitForSeconds(4);
            rocketConfirmation.Play();
            yield return new WaitForSeconds(3);
            GameObject icbm = GameObject.Instantiate(SSD, precision, Quaternion.identity);
            icbm.SetActive(true);
            isSpook = true;
        }
        yield return new WaitForSeconds(60);
        isSpook = false;
    }
    IEnumerator artillery()
    {
        RaycastHit rc = new RaycastHit();
        float zpos = -mark.z;
        Ray rayOrigin = new Ray(rifle.transform.position, rifle.transform.forward);
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
