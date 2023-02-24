using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();    
        }
    }

    void Shoot() {

        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)) {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null) {
                enemy.TakeDamage(damage);
            }
        }
    }
}
