using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Flipkart
{
    public  Button ATC;
    public TMP_Text item;
    public TMP_Text Franchise;
    public GameObject Panel;
    void Update()
    {

    }

    public void OnClick()
    {
        AddtoCart(item.ToString());
    } 
    
}
