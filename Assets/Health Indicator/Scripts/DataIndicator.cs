using UnityEngine;

public class DataIndicator : MonoBehaviour
{
    [SerializeField] protected Health Character;

    private void OnEnable()
    {
        Character.HealthChanged += UpdateData;
    }

    private void OnDisable()
    {
        Character.HealthChanged -= UpdateData;
    }

    protected virtual void UpdateData(float value, float maxValue) { }
}
