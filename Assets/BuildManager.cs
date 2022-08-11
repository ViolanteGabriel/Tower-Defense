using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static BuildManager istance;
    void Awake() {
        if (instance!= null){
            Debug.Debug.LogError("More than one BuildManager in scene !");
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

void Start() {
    turreToBuild = standardTurretPrefab;

}
private GameObject turreToBuild;

 
 public GameObject GetTurretToBuild(){
        return turreToBuild;
 }
}
