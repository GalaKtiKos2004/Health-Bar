using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBarView : MonoBehaviour
{
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void UpdateBar(float currentHealth, float maxHealth)
    {
        _image.fillAmount = currentHealth / maxHealth;
    }
}
