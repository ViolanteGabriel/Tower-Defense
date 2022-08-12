using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private Color hoverColor;
    private GameObject turret;
    public Vector3 positionOffset;

    private Renderer render;


    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    void OnMouseDown()
    {
        if (turret != null) return;

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter() { render.material.color = hoverColor; }

    void OnMouseExit() { render.material.color = startColor; }

}