using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {
    public Color hoverColor = Color.green;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    public Vector3 offset;
    

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
	void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);
    }
}
