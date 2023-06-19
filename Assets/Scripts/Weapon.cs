using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Serialization;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Camera FPCamera;
    [SerializeField] private float range = 100f;
    [SerializeField] private float damage = 10;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            //Debug.Log("I hit this thing: " + hit.transform.name);
            //TODO: add some hit effect for visual effects
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (!target)
                return;
            
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
        
    }
}
