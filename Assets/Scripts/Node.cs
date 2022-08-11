using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private Color hoverColor;
    [SerializeField] private GameObject turret;
    public Vector3 positionOffset;

    private Renderer render;

   
    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    void OnMouseDown(){
        if (turret != null ){
            Debug.Log("Não Pode construir nesse bloco");
            return;
        }
        turret = (GameObject)Instantiate(turreToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter() { render.material.color = hoverColor; }

    void OnMouseExit() { render.material.color = startColor; }

    void OnMouseClick() 
    {
        if (turret != null) return;
    }
}
