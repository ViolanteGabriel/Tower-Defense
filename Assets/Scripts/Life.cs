using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBox;

    public PlayerData player;

    void Update()
    {
        textBox.text = "Life: " + PlayerData.life;
    }
}
