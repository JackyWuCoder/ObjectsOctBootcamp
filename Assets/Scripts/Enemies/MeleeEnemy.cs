using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private float attackTime = 0f;

    private float timer = 0;

    protected override void Start()
    {
        base.Start();
        health = new Health(1, 1, 0);
    }

    protected override void Update()
    {
        base.Update();
        if (target = null)
        {
            return;
        }
        if(Vector2.Distance(transform.position, target.position) < attackRange)
        {
            Attack(attackTime);
        }
    }
}
