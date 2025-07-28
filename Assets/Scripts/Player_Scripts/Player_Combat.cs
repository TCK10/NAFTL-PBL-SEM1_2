using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Combat : MonoBehaviour
{
    public Transform attackPoint;
    public LayerMask enemyLayer;

    public Animator anim;

    public float cooldown  ;
    private float timer;
    public SoundPlayer soundPlayer;

    public void Update()
    {
        if(timer >0)
        {
            timer -= Time.deltaTime;
        }
    }

    public void Attack()
    {
        if(timer<= 0)
        {
            anim.SetBool("isAttacking", true);
                

            timer = cooldown;
        }
    }

    public void DealDamage()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.position, StatsManager.Instance.weaponRange, enemyLayer);

            if(enemies.Length >0)
            {
                enemies[0].GetComponent<Enemy_Health>().ChangeHealth(-StatsManager.Instance.damage);
            }
    }


    public void FinishAttacking()
    {
        anim.SetBool("isAttacking", false);
    }


}
