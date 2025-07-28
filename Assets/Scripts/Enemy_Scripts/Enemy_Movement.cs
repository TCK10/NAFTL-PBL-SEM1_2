using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public float moveSpeed;
    public float attackRange;
    public float attackCooldown;
    public float playerDetectRange;
    public Transform detectionPoint;
    public LayerMask playerLayer;

    private float attackCooldownTimer;
    private int facingDir = 1;
    private EnemyState enemyState;
    public Rigidbody2D rb;
    public Transform player;
    public Animator anim;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ChangeState(EnemyState.Idle);
    }

    private void Update()
    {   
        CheckForPlayer();

        if(attackCooldownTimer > 0)
        {
            attackCooldownTimer -= Time.deltaTime;
        }

        if (enemyState  == EnemyState.Chasing)
        {
            Chase();
        }
        else if (enemyState  == EnemyState.Attacking)
        {
            //do attacky stuff
            // Attack();
            rb.velocity = Vector2.zero;
        }
    }

    void Chase()
    {
        

        if(player.position.x > transform.position.x && facingDir == -1 || 
                player.position.x < transform.position.x && facingDir == 1)
        {
            Flip();
        }

            // Chase the player
            Vector2 direction = (player.position - transform.position).normalized;
            rb.velocity = direction * moveSpeed;
    }

    void Flip()
    {
        facingDir *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }


    private void CheckForPlayer()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(detectionPoint.position, playerDetectRange, playerLayer);

        if(hits.Length > 0)
        {
            player = hits[0].transform;

            if(Vector2.Distance(transform.position, player.position) <= attackRange && attackCooldownTimer <= 0) 
            {
                attackCooldownTimer = attackCooldown;
                ChangeState(EnemyState.Attacking);
            }
            
            else if(Vector2.Distance(transform.position, player.position) > attackRange)
            {
                ChangeState(EnemyState.Chasing);
            }

            
        }
        else
        {
            rb.velocity = Vector2.zero;
            ChangeState(EnemyState.Idle);
        }
    }



    private void ChangeState(EnemyState state)
    {
            enemyState = state;

            anim.SetBool("isIdle", state == EnemyState.Idle);
            anim.SetBool("isChasing", state == EnemyState.Chasing);
            anim.SetBool("isAttacking", state == EnemyState.Attacking);

    }

}

public enum EnemyState
{
    Idle,
    Chasing,
    Attacking
}