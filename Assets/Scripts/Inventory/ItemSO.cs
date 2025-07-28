using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class ItemSO : ScriptableObject
{
    public string  itemName;
    public Sprite icon;
    
    public bool isFrame;
    public bool isSword;
    public bool isAnklet;

    [Header("Stats")]
    public int currentHealth;
    public int maxHealth;
    public int damage;
    public int speed;


}
