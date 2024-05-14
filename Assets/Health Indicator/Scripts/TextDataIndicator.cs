using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextDataIndicator : DataIndicator
{
    private const string TextBarSeparator = " / ";

    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    protected override void UpdateData(float value, float maxValue)
    {
        _text.text = value + TextBarSeparator + maxValue;
    }
}