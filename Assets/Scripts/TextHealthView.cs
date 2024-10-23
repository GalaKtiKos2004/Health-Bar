using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHealthView : HealthView
{
    private TextMeshProUGUI _text;
    private Health _health;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    protected override void UpdateHealth(float currentHealth, float maxHealth)
    {
        _text.text = $"{currentHealth} / {maxHealth}";
    }
}
