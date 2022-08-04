using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    private float lastGeneration;
    [Range(0, 3)]
    [SerializeField] private float WaveCooldown = 2f;
    private int currentWave = 0;

    void Update()
    {
        GenerateEnemy();
    }

    private void GenerateEnemy()
    {
        float nowTime = Time.time;

        if (nowTime > lastGeneration + WaveCooldown)
        {
            currentWave++;
            lastGeneration = nowTime;
            Vector3 generatorPosition = this.transform.position;

            Instantiate(Enemy, generatorPosition, Quaternion.identity);
        }
    }
}
