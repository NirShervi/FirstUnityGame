using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalProj : BaseProj
{
    Vector3 diraction;
    bool fired;
    
    void Update()
    {
        if (fired)
        {
            transform.position +=  diraction * (speed *Time.deltaTime);
        }  

    }
    public override void FireProjectile(GameObject barrle,GameObject target, int damage)
    {
        if(barrle && target)
        {
            diraction = (target.transform.position - barrle.transform.position).normalized;
            fired = true;
        }
    }

    
}
