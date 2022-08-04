using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject endOfPath = GameObject.Find("endOfPath");
        Vector3 endOfPathCoordinates = endOfPath.transform.position;

        agent.SetDestination(endOfPathCoordinates);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
