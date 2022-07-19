using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMoney : MonoBehaviour
{
    public CollectBar collectBar;
    public Text mainMoney;
    public float money;
    public Button bukatoko;
    public GameObject people;
    
    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        mainMoney.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        mainMoney.text = money.ToString();
    }

    public void BukaToko(){
        collectBar.isFill = true;
        bukatoko.gameObject.SetActive(false);
    }

    public void BeliOrang(){
        collectBar.isFill = true;
        collectBar.isAuto = true;
        people.SetActive(true);
        bukatoko.gameObject.SetActive(false);
    }
}
