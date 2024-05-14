using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderBar : Bar
{
    protected Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    protected override void UpdateBar(float value, float maxValue)
    {
        _slider.value = value / maxValue;
    }
}