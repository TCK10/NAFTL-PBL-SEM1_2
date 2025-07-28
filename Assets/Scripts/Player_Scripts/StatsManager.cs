    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using TMPro;

    using UnityEngine.UI;

    public class StatsManager : MonoBehaviour
    {
        public static StatsManager Instance;
        public Slider slider;
        public TMP_Text healthText;

        [Header("Combat Stats")]
        public int damage;
        public float weaponRange;

        [Header("Movement Stats")]
        public int speed;

        [Header("Health Stats")]
        public int maxHealth;
        public int currentHealth;

        private void Awake()
        {
            if(Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }

        public void UpdateHealth(int amount)
        {
            currentHealth += amount;
            Debug.Log("change heatlh etxt");
            healthText.text = currentHealth.ToString();
            slider.value = currentHealth;
        }

                
    }

