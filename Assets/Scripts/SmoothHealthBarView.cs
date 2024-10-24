using System.Collections;
using UnityEngine;

public class SmoothHealthBarView : HealthBarView
{
    [SerializeField] private float _smooothDecreaseDuration = 0.25f;

    protected override void UpdateHealth(float currentHealth, float maxHealth)
    {
        StartCoroutine(DecreaseHealthSmoothly(currentHealth / maxHealth));
    }

    private IEnumerator DecreaseHealthSmoothly(float targetHealth)
    {
        float elapsedTime = 0f;
        float previousValue = FillAmount;

        while (elapsedTime < _smooothDecreaseDuration)
        {
            elapsedTime += Time.deltaTime;
            float normalizedPosition = elapsedTime / _smooothDecreaseDuration;
            float intermediateValue = Mathf.Lerp(previousValue, targetHealth, normalizedPosition);
            UpdateImage(intermediateValue);

            yield return null;
        }
    }
}
