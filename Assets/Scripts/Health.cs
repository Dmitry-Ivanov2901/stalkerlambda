using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100.0f;
    public float currentHealth;
    public GameObject spawn;
    public GameObject player;
    public int maxWaves;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 100.0f;
    }
    public IEnumerator respawn()
    {
        Debug.Log($"Bot {gameObject.name} has been killed.");
        if (maxWaves > 0)
        {
            maxWaves--;
            gameObject.transform.position = spawn.transform.position;
            currentHealth = health;
        }
        else
        {
            yield return null;
            gameObject.SetActive(false);
            if (gameObject.CompareTag("enemy"))
            {
                playerHealth ph = player.GetComponent<playerHealth>();
                ph.remainingEnemies--;
            }
        }
    }
    public IEnumerator decreaseHealth76239()
    {
        yield return null;
        currentHealth -= 41.0f;
    }
    public IEnumerator decreaseHealth545()
    {
        yield return null;
        currentHealth -= 25.0f;
    }
    public IEnumerator decreaseHealth556()
    {
        yield return null;
        currentHealth -= 24.0f;
    }
    public IEnumerator decreaseHealth76251()
    {
        yield return null;
        currentHealth -= 50.0f;
    }
    public IEnumerator decreaseHealth76225()
    {
        yield return null;
        currentHealth -= 33.0f;
    }
    public IEnumerator decreaseHealth10mm()
    {
        yield return null;
        currentHealth -= 50.0f;
    }
    public IEnumerator decreaseHealthExplo()
    {
        yield return null;
        currentHealth -= 100.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0.0f ||  currentHealth <= 0.0f) 
        {
             StartCoroutine(respawn());
        }
    }
}
