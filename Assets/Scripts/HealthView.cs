using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    private Health _health;

    protected Health PlayerHealth => _health;

    private void OnEnable()
    {
        _health.HealthChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateHealth;
    }

    public void Construct(Health health)
    {
        _health = health;
    }

    protected virtual void UpdateHealth(float health, float maxHealth) { }
}
