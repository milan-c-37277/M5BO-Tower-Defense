using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefabEnemy;
    [SerializeField] GameObject goalObject;
    public List<GameObject> enemyList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(enemyList.Count < 2)
        {
            GameObject newEnemy = Instantiate(prefabEnemy);
            newEnemy.transform.position = GetComponentInParent<Transform>().position; // location not working properly
            Enemy enemyScript = newEnemy.GetComponent<Enemy>();
            enemyScript.goal = goalObject.transform;
            enemyList.Add(newEnemy);
            
        }
    }
}
