using UnityEngine;

public class Bullet : MonoBehaviour {
    private Transform target;
    public float speed = 70f;
    public GameObject impactEffect;

	// Update is called once per frame
	void Update () {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
	}

    public void Seek(Transform this_target)
    {
        target = this_target;
    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(effectIns, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }

}
