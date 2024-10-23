using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private TextHealthView _healthText;
    [SerializeField] private HealthBarView _healthBar;
    [SerializeField] private SmoothHealthBarView _smoothHealthBar;

    [SerializeField] private float _maxHealth = 100f;

    private Health _health;

    private void Awake()
    {
        _health = new Health(_maxHealth);
    }

    private void Start()
    {
        UpdateHealth();
    }

    public void TryGetDamage(float damage)
    {
        _health.TakeDamage(damage);
        UpdateHealth();
    }

    public void TryAddHealth(float recoverHealth)
    {
        _health.TryAddHealth(recoverHealth);
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        _healthText.UpdateText(_health.CurrentHealth, _maxHealth);
        _healthBar.UpdateBar(_health.CurrentHealth, _maxHealth);
        _smoothHealthBar.UpdateBar(_health.CurrentHealth / _maxHealth);
    }
}
