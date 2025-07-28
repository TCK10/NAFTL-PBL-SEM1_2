using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{   
    public Slider slider;
    public GameObject HealthTextPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StatsManager.Instance.currentHealth = StatsManager.Instance.maxHealth;
        slider.maxValue = StatsManager.Instance.maxHealth;
        slider.value = StatsManager.Instance.currentHealth;
    }

    public void TakeDamage(int amount)
    {  
        StatsManager.Instance.currentHealth -= amount;
        slider.value = StatsManager.Instance.currentHealth;

        if(StatsManager.Instance.currentHealth <= 0)
        {
            Debug.Log("Dead");
            SceneManager.LoadSceneAsync(5);
        }

        HealthTextPrefab.GetComponentInChildren<TMP_Text>().text = StatsManager.Instance.currentHealth.ToString();
    }

    public void Update()
    {
        HealthTextPrefab.GetComponentInChildren<TMP_Text>().text = StatsManager.Instance.currentHealth.ToString();   
    }


}
