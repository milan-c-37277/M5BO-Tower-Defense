using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Waves waves;
    [SerializeField] GameObject Spawn1;
    [SerializeField] GameObject Spawn2;
    [SerializeField] GameObject Spawn3;
    public GameObject currentSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (waves.waveLevel == 1)
        {
            currentSpawn = Spawn1;
        }
        else if (waves.waveLevel == 2)
        {
            currentSpawn = Spawn2;
        }
        else if (waves.waveLevel == 3)
        {
            currentSpawn = Spawn3;
        }
    }
}
