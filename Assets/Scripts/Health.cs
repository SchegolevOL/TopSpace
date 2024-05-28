using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHP;
    int currHP;
    HealthBar healthBar;

    private void Start()
    {
        currHP = maxHP;
        healthBar = GetComponentInChildren<HealthBar>();
        healthBar.SetBarValue(currHP, maxHP);
    }

    public void GetDamage(int damage)
    {
        currHP = Mathf.Clamp(currHP - damage, 0, maxHP);
        healthBar.SetBarValue(currHP, maxHP);
        if (currHP == 0) Destroy(gameObject);
    }

}
