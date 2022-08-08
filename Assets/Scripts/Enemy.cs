using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private int life = 21;

    public void ReceiveDamage(int damage)
    {
        life -= damage;
        if (life <= 0) Destroy(this.gameObject);
    }
	
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
