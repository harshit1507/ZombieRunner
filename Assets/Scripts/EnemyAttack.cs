using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private PlayerHealth target;
    [SerializeField] private float damage = 40f;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    private void AttackHitEvent()
    {
        if (!target)
            return;
        
        target.TakeDamage(damage);
    }
}
