using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StatsUI : MonoBehaviour
{
    public GameObject[] statSlots;

    void Start()
    {
        UpdateAllStats();
    }



    // Update is called once per frame
    void UpdateDamage()
    {
        statSlots[0].GetComponentInChildren<TMP_Text>().text = "Damage: " + StatsManager.Instance.damage;
    }

    void UpdateSpeed()
    {
        statSlots[1].GetComponentInChildren<TMP_Text>().text = "Speed: " + StatsManager.Instance.speed;
    }

    public void UpdateAllStats()
    {        
        UpdateDamage();
        UpdateSpeed();
    }
}
