using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Health _target;
    [SerializeField] private float _damage = 5;
    [SerializeField] private float _heal = 10;

    public void Attack()
    {
        _target.TakeDamage(_damage);
    }

    public void Heal()
    {
        _target.TakeHeal(_heal);
    }
}
