using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {
    public Color hoverColor = Color.green;
    public Color noMoney = Color.red;
    private Renderer rend;
    private Color startColor;
    public Vector3 offset;
    BuildManager buildManager;
    [Header("Optional")]
    public GameObject turret;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }
	void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject() || !buildManager.CanBuild) return;
        if(buildManager.HaveMoney) rend.material.color = hoverColor;
        else rend.material.color = noMoney;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject() || !buildManager.CanBuild) return;
        if(turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        buildManager.BuildTurretOn(this);
    }

    public Vector3 GetBuildPosition() { return transform.position + offset; }
}
