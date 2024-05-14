using System.Collections;
using UnityEngine;

public class SmoothSliderBar : SliderBar
{
    [SerializeField] private float _duration = 10f;
    
    private Coroutine _coroutine = null;

    protected override void UpdateData(float value, float maxValue)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(FillingBar(value / maxValue));
    }

    private IEnumerator FillingBar(float targetValue)
    {
        float elapsed = 0;
        float currentValue = _slider.value;

        while (elapsed < _duration)
        {
            currentValue = Mathf.Lerp(currentValue, targetValue, elapsed / _duration);
            _slider.value = currentValue;

            elapsed += Time.deltaTime;

            yield return null;
        }
    }
}
