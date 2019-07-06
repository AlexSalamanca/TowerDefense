using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    private GameObject turretToBuild;
    public GameObject standardTurretToBuild;
    public GameObject missilesTurretToBuild;


    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one build manager in scene");
            return;
        }
        instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
