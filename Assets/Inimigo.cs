using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject fimDoCaminho = GameObject.Find ("fimDoCaminho");
        Vector3 posicaoFimDoCaminho = fimDoCaminho.transform.position;
        enemy.SetDestination (posicaoFimDoCaminho);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
