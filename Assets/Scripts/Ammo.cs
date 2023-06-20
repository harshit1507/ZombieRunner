using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private int ammoAmount = 10;

    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
    }

    public int GetCurrentAmmoAmount()
    {
        return ammoAmount;
    }
}
