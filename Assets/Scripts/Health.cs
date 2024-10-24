using System;
using UnityEngine;

public class Health
{
    private float _maxHealth;

    public event Action<float, float> HealthChanged;

    public Health(float maxHealth)
    {
        _maxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }

    public float CurrentHealth { get; private set; }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            return;
        }

        CurrentHealth = Mathf.Clamp(CurrentHealth - damage, 0, _maxHealth);
        HealthChanged?.Invoke(CurrentHealth, _maxHealth);
    }

    public void TryTreated(float recoverHealth)
    {
        if (recoverHealth < 0)
        {
            return;
        }

        CurrentHealth = Mathf.Clamp(CurrentHealth + recoverHealth, 0, _maxHealth);
        HealthChanged?.Invoke(CurrentHealth, _maxHealth);
    }
}