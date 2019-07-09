using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    private TurretBlueprint turretToBuild;
    public GameObject standardTurretToBuild;
    public GameObject missilesTurretToBuild;
    public GameObject buildEffect;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one build manager in scene");
            return;
        }
        instance = this;
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HaveMoney { get { return PlayerStats.money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {
        if(PlayerStats.money < turretToBuild.cost)
        {
            Debug.Log("Not enough money!");
            return;
        }

        PlayerStats.money -= turretToBuild.cost;
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
        Debug.Log(PlayerStats.money);

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
    }
}
