using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUpgrade : MonoBehaviour
{
    public CollectBar collectBar;
    public MainMoney mainMoney;
    public Button upgrade;
    public float cost;

    void Start()
    {
        cost = 4;
        upgrade.GetComponentInChildren<Text>().text = cost.ToString();
    }

    void Update()
    {
        if(mainMoney.money >= cost){
            upgrade.interactable = true;
        }else{
            upgrade.interactable = false;
        }
    }

    public void Upgrade(){
        mainMoney.money -= cost;
        cost += 2;
        collectBar.value += 2;
        upgrade.GetComponentInChildren<Text>().text = cost.ToString();
    }
}
