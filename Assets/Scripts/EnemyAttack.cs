using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float damage = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void AttackHitEvent()
    {
        if (!target)
            return;
        
        Debug.Log("Attacking target");
    }
}
