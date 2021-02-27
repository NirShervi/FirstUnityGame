using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseProj : MonoBehaviour
{
    public float speed = 5f;
    public abstract void FireProjectile(GameObject barrle, GameObject target, int damage);
}
