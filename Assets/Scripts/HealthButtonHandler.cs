using UnityEngine;

public class HealthButtonHandler : MonoBehaviour
{
    private Health _health;

    public void Construct(Health health)
    {
        _health = health;
    }

    public void TryGetDamage(float damage)
    {
        _health.TakeDamage(damage);
    }

    public void TryAddHealth(float recoverHealth)
    {
        _health.TryTreated(recoverHealth);
    }
}
