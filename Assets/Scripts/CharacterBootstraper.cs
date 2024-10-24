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

        _textHealth.Init(health);
        _healthBar.Init(health);
        _smoothHealthBar.Init(health);
        _healthButtonHandler.Construct(health);
    }
}
