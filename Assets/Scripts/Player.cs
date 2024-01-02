using UnityEngine;

public class Player : PlayableObject
{
    private string nickName;
    private float speed;

    // public Health health = new Health();

    /*
    public void Move(Vector3 direction)
    {
        Debug.Log($"Moving towards {direction}");
    }
    */

    public override void Move()
    {
        base.Move();
    }

    public override void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public override void Die()
    {
       base.Die();
    }
}
