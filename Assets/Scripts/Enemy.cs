using UnityEngine;

public class Enemy : PlayableObject
{
    private string enemyName;
    private float speed;
    private EnemyType enemyType;

    public override void Shoot()
    {
        Debug.Log($"Shooting a bullet");
    }

    public override void Die()
    {
        Debug.Log("Player Died");
    }

    public override void Attack(float interval)
    {
        Debug.Log($"Enemy attacking with a {interval} interval");
    }

    public void SetEnemyType(EnemyType _enemyType)
    {
        enemyType = _enemyType;
    }

    public override void Move(Vector2 direction, Vector2 target)
    {
        
    }

    public override void GetDamage(float damage)
    {
        
    }
}
