using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : GameManager
{
    [SerializeField] string nam;
    [SerializeField] string price;
    
   
    public void UIenabler()
    {
        item.text = price;
        Franchise.text = nam;
        bool isActive = Panel.activeSelf;
        Panel.SetActive(!isActive);
    }

    
    
}
