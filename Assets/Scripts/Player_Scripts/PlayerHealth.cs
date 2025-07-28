using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Animator fadeAnim;
    public SoundPlayer soundPlayer;

    public void ChangeHealth(int amount)
    {
        StatsManager.Instance.currentHealth += amount;
        soundPlayer.Damaged();  

        if(StatsManager.Instance.currentHealth <= 0)
        {
            SceneManager.LoadSceneAsync(3);
            Debug.Log("death screen");  
        }
    }


}
