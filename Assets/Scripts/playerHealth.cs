using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playerHealth : MonoBehaviour
{
    public float health = 100.0f;
    public float currentHealth;
    public int maxWaves;
    public GameObject spawn;
    public GameObject go;
    public VideoPlayer victory;
    public VideoPlayer defeat;
    public GameObject win;
    public GameObject loss;
    public int remainingEnemies = 20;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 100.0f;
    }
    public void respawn()
    {
        if (maxWaves > 0)
        {
            Debug.Log("You have been killed");
            currentHealth = 100.0f;
            go.transform.position = spawn.transform.position;
            maxWaves--;
        }
        else
        {
            loss.SetActive(true);
            defeat.Play();
        }
    }
    public IEnumerator decreaseHealth76239()
    {
        yield return null;
        Debug.Log("HIT");
        currentHealth -= 41.0f;
    }
    public IEnumerator decreaseHealth545()
    {
        yield return null;
        Debug.Log("HIT");
        currentHealth -= 25.0f;
    }
    public IEnumerator decreaseHealth556()
    {
        yield return null;
        Debug.Log("HIT");
        currentHealth -= 24.0f;
    }
    public IEnumerator decreaseHealth76251()
    {
        yield return null;
        Debug.Log("HIT");
        currentHealth -= 50.0f;
    }
    public IEnumerator decreaseHealth76225()
    {
        yield return null;
        Debug.Log("HIT");
        currentHealth -= 33.0f;
    }
    public IEnumerator decreaseHealthExplo()
    {
        yield return null;
        Debug.Log("HIT");
        currentHealth -= 100.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0.0f || currentHealth <= 0.0f)
        {
            respawn();
        }
        if(remainingEnemies <= 0)
        {
            win.SetActive(true);
            victory.Play();
        }
    }
}
