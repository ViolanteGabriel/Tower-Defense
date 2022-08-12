using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitDetector : MonoBehaviour
{
    [SerializeField] private PlayerData player;
    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);   
        PlayerData.life--;

    }
}
