using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    private GameObject turretToBuild;
    public GameObject standardTurretToBuild;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one build manager in scene");
            return;
        }
        instance = this;
    }
    void Start()
    {
        turretToBuild = standardTurretToBuild;
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
