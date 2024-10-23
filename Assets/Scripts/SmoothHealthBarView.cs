using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SmoothHealthBarView : MonoBehaviour
{
    [SerializeField] private float _smooothDecreaseDuration = 0.25f;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void UpdateBar(float currentHealth)
    {
        StartCoroutine(DecreaseHealthSmoothly(currentHealth));
    }

    private IEnumerator DecreaseHealthSmoothly(float targetHealth)
    {
        float elapsedTime = 0f;
        float previousValue = _image.fillAmount;

        while (elapsedTime < _smooothDecreaseDuration)
        {
            elapsedTime += Time.deltaTime;
            float normalizedPosition = Mathf.Abs(targetHealth - previousValue) * (elapsedTime / _smooothDecreaseDuration);
            float intermediateValue = Mathf.MoveTowards(previousValue, targetHealth, normalizedPosition);
            _image.fillAmount = intermediateValue;

            yield return null;
        }
    }
}
