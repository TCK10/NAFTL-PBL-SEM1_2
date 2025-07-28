using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public int facingDir = 1;
 
  public Rigidbody2D rb;
  public Animator anim;

  public Player_Combat player_Combat;
    public SoundPlayer soundPlayer;

  private void Update()
  { 
    if(Input.GetButtonDown("Slash"))
    {
      player_Combat.Attack();
    }
  }


  void FixedUpdate()
  {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    if(horizontal > 0 && transform.localScale.x < 0 || 
      horizontal < 0 && transform.localScale.x > 0)
    { 
      Flip();
    }

    anim.SetFloat("horizontal", Mathf.Abs(horizontal));
    anim.SetFloat("vertical", Mathf.Abs(vertical));

    rb.velocity = new Vector2(horizontal, vertical) * StatsManager.Instance.speed;
  }
  
  void Flip()
  {
    facingDir *= -1;
    transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
  }

}