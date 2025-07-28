using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] itemSlots;
    public UseItem useItem;
    public int Frame;
    public TMP_Text frameText;
    public int Sword;
    public TMP_Text swordText;
    public int Anklet;
    public TMP_Text ankletText;
    
    public MonoBehaviour SoundPlayer;
    
    private void Start()
    {
        foreach (var slot in itemSlots)
        {
            slot.UpdateUI();
        }
    }

    private void OnEnable()
    {
        Loot.OnItemLooted += AddItem;
    }

    private void OnDisable()
    {
        Loot.OnItemLooted -= AddItem;
    }

    public void AddItem(ItemSO itemSO, int quantity)
    {
        // GetComponent<SoundPlayer>().ItemPU();

        if(itemSO.isFrame)
        {
            Frame += quantity;
            frameText.text = Frame.ToString();
            return;
        }
        else if(itemSO.isSword)
        {
            Sword += quantity;
            swordText.text = Sword.ToString();
            return;
        }
        else if(itemSO.isAnklet)
        {
            Anklet += quantity;
            ankletText.text = Anklet.ToString();
            return;
        }

        foreach (var slot in itemSlots)
        {
            if (slot.itemSO == null || slot.itemSO == itemSO)
            {
                slot.itemSO = itemSO;
                slot.quantity += quantity;
                slot.UpdateUI();
                return;
            }
        }
    }

    public void UseItem(InventorySlot slot)
    {
        if(slot.itemSO != null && slot.quantity >= 0)
        {
            useItem.ApplyItemEffects(slot.itemSO);

            slot.quantity--;
            if(slot.quantity <= 0)
            {
                slot.itemSO = null;
            }
            slot.UpdateUI();
        }
    }
}