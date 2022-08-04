using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeTropas : MonoBehaviour
{
    public Transform enemyPrefab;
    public float tempoEntreOndas = 5f;
    private float contagem = 1f;

    void Update ()
    {

    }

    void SpawnOnda ()
    {
        Debug.Log("Mais uma onda!!");
    }
}
