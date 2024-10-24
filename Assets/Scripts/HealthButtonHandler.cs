using UnityEngine;
using UnityEngine.UI;

public class HealthButtonHandler : MonoBehaviour
{
    [SerializeField] private Button _damageButton;
    [SerializeField] private Button _treatedButton;

    [SerializeField] private float _damage;
    [SerializeField] private float _recoverHealth;

    private Health _health;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(TryGetDamage);
        _treatedButton.onClick.AddListener(TryAddHealth);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(TryGetDamage);
        _damageButton.onClick.RemoveListener(TryAddHealth);
    }

    public void Construct(Health health)
    {
        _health = health;
    }

    private void TryGetDamage()
    {
        _health.TakeDamage(_damage);
    }

    private void TryAddHealth()
    {
        _health.TryTreated(_recoverHealth);
    }
}
