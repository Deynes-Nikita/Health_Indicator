using System;
using UnityEngine;

public class Health : MonoBehaviour
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
        damage = Mathf.Abs(damage);
        ChangeHealth(-damage);
    }

    public void TakeHeal(float heal)
    {
        heal = Mathf.Abs(heal);
        ChangeHealth(heal);
    }

    private void ChangeHealth(float value)
    {
        _currentHealth = Mathf.Clamp((_currentHealth + value), 0, _maxHealth);

        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}
