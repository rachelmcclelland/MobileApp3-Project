using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform gun;
    [SerializeField] private Bullet bullet;

    public void Start()
    {
        // fire a bullet from the gun
        // instantiate a bullet
        Instantiate(bullet, gun.transform.position, transform.rotation, gun);
    }
}
