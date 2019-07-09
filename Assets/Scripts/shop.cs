using UnityEngine;
//TODO: Improve the shop interface
public class shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissileTurret()
    {
        buildManager.SelectTurretToBuild(missileTurret);
    }
}
