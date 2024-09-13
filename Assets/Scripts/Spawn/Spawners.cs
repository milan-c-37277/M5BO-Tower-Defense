using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public float cooldown = 10;
    public float waveSpawnRate;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        cooldown -= Time.deltaTime;
        Debug.Log(gameObject.name + " Cooldown: " + cooldown);
        if (cooldown < 0)
        {
            GameObject Enemy = Instantiate(enemy, transform.position, Quaternion.identity);
            cooldown = 10;
        }
        
    }
}
