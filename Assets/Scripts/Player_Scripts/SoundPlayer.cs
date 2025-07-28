using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [Header ("AudioSource")]
    public AudioSource tsfSource;
    public AudioSource villageSource; 
    public AudioSource punchSource; 
    public AudioSource itemUseSource; 
    public AudioSource itemPUSource; 
    public AudioSource damagedSource; 
    public AudioSource bossEndSource; 

    [Header ("AudioClip")]
    public AudioClip tsfClip;
    public AudioClip villageClip; 
    public AudioClip punchClip; 
    public AudioClip itemUseClip; 
    public AudioClip itemPUClip; 
    public AudioClip damagedClip; 
    public AudioClip bossEndClip; 

    void Start()
    {
        villageSource.loop = true; 
        villageSource.Play(); 
    }

    public void Punch()
    {
        punchSource.PlayOneShot(punchClip); 
    }
    
    public void Damaged()
    {
        damagedSource.PlayOneShot(damagedClip); 
    }
    
    public void ItemPU()
    {
        itemPUSource.PlayOneShot(itemPUClip); 
    }
    public void ItemUse()
    {
        itemUseSource.PlayOneShot(itemUseClip); 
    }
}