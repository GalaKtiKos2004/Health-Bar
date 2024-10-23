using UnityEngine;

public class CharacterBootstraper : MonoBehaviour
{
    [SerializeField] private TextHealthView _textHealth;
    [SerializeField] private HealthBarView _healthBar;
    [SerializeField] private SmoothHealthBarView _smoothHealthBar;
    [SerializeField] private HealthButtonHandler _healthButtonHandler;

    [SerializeField] private float _maxHealth;

    private void Awake()
    {
        Health health = new Health(_maxHealth);

        _textHealth.Construct(health);
        _healthBar.Construct(health);
        _smoothHealthBar.Construct(health);
        _healthButtonHandler.Construct(health);
    }
}
