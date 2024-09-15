using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public Transform goal;
    NavMeshAgent agent;
    public int health = 10;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, goal.position) < 0.3)
        {
            Destroy(gameObject, 1f);
        }
    }
}
