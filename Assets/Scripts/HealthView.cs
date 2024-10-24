using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    private Health _health;

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateHealth;
    }

    public void Init(Health health)
    {
        _health = health;
        _health.HealthChanged += UpdateHealth;
    }

    protected virtual void UpdateHealth(float health, float maxHealth) { }
}
