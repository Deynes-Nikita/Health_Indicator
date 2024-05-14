using UnityEngine;

public class Bar : MonoBehaviour
{
    protected Character Character;

    private void Awake()
    {
        Character = GetComponentInParent<Character>();
    }

    private void OnEnable()
    {
        Character.HealthChanged += UpdateBar;
    }

    private void OnDisable()
    {
        Character.HealthChanged -= UpdateBar;
    }

    protected virtual void UpdateBar(float value, float maxValue) { }
}
