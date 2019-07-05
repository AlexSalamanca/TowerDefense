using UnityEngine;
//TODO: Improve the shop interface
public class shop : MonoBehaviour {
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standardTurretToBuild);
    }
    public void PurchaseMissileTurret()
    {
        buildManager.SetTurretToBuild(buildManager.missilesTurretToBuild);
    }
}
