using System.Collections;
using UnityEngine;

public class SmoothSliderBar : SliderBar
{
    [SerializeField] private float _volumeChangeSpeed = 10f;

    private float _currentValue;
    private Coroutine _coroutine = null;

    protected override void UpdateBar(float value, float maxValue)
    {
        if (_coroutine == null)
            _currentValue = value;

        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(FillingBar(value, maxValue));
    }

    private IEnumerator FillingBar(float targetValue, float maxValue)
    {
        float interpolationValue = (_volumeChangeSpeed * Time.deltaTime);

        while (_slider.value != targetValue / maxValue)
        {
            _currentValue = Mathf.MoveTowards(_currentValue, targetValue, interpolationValue);
            _slider.value = _currentValue / maxValue;
            yield return null;
        }
    }
}
