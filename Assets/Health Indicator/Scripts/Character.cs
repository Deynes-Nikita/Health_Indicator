using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100;

    private float _currentHealth;

    public event Action<float, float> HealthChanged;

    private void Start()
    {
        _currentHealth = _maxHealth;
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeDamage(float damage)
    {
        ChangeHealth(-damage);
    }

    public void TakeHeal(float heal)
    {
        ChangeHealth(heal);
    }

    private void ChangeHealth(float value)
    {
        _currentHealth = Mathf.Clamp((_currentHealth + value), 0, _maxHealth);

        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}
