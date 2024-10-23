using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBarView : HealthView
{
    private Image _image;

    protected float FillAmount => _image.fillAmount;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    protected override void UpdateHealth(float currentHealth, float maxHealth)
    {
        UpdateImage(currentHealth / maxHealth);
    }

    protected void UpdateImage(float value)
    {
        _image.fillAmount = value;
    }
}
