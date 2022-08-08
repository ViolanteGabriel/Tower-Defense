using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private Color hoverColor;

    private Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    void OnMouseEnter() { render.material.color = hoverColor; }

    void OnMouseExit() { render.material.color = startColor; }
}
