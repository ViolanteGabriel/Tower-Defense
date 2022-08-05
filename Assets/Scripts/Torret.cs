using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret : MonoBehaviour
{
    public Transform target;
    public float range = 30f;
    public string enemyTag = "Enemy";


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTorretTarget", 0f, 0.5f);
    }

    void UpdateTorretTarget()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        GameObject nearestEnemy = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject enemy in Enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range) target = nearestEnemy.transform;
        else target = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
    }

}
