using UnityEngine;
using TMPro;

public class Enemy_Combat : MonoBehaviour
{   
    public int damage;
    public Transform attackPoint;
    public float weaponRange;
    public LayerMask playerLayer;
    
    private Health playerHealth;
    // private SpawnerScript spawner;
    // public GameObject popUpDamagePrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (playerHealth == null)
            {
                playerHealth = collision.gameObject.GetComponent<Health>();
            }
            
            // spawner.PopUpDamageSpawn(damage);
            // playerHealth.TakeDamage(damage);
        }
    }

    public void Attack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(attackPoint.position, weaponRange, playerLayer);

        if(hits.Length >0)
        {
            hits[0].GetComponent<Health>().TakeDamage(damage);
            // playerHealth = gameObject.GetComponent<Health>();
            // playerHealth.TakeDamage(damage);
        }

    }
}