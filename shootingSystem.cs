using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingSystem : MonoBehaviour
{

    public float fireRate;
    public int damage;
    public float fieldOfView;
    public GameObject projectile;
    public List<GameObject> projectileSpawns;
    public GameObject target;

    List<GameObject> lastProjectiles = new List<GameObject>();

    float fireTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= fireRate)
        {
            float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position ));
            if (angle < fieldOfView)
            {
                spawnProjectiles();
                fireTimer = 0f;
            }
        }
    }

    void spawnProjectiles()
    {
        if (!projectile)
        {
            return;
        }
        lastProjectiles.Clear();
        for(int i = 0; i < projectileSpawns.Count; i++)
        {
            if (projectileSpawns[i])
            {
                GameObject proj = Instantiate(projectile, projectileSpawns[i].transform.position, Quaternion.Euler(projectileSpawns[i].transform.forward)) as GameObject;
                proj.GetComponent<BaseProj>().FireProjectile(projectileSpawns[i], target, damage);
                lastProjectiles.Add(proj);
            }
        }
    }
}
