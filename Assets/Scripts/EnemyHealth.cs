using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   [SerializeField] private float enemyHealth = 100f;
   [SerializeField] private bool isDead = false;

   public void TakeDamage(float damage)
   {
      if (!isDead)
      {
         BroadcastMessage("OnDamageTaken");
         enemyHealth -= damage;
         if (enemyHealth <= 0)
         {
            Die();
         }
      }
   }

   private void Die()
   {
      isDead = true;
      GetComponent<Animator>().SetTrigger("die");
   }

   public bool IsDead()
   {
      return isDead;
   }
}
