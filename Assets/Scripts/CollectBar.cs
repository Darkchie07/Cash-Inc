using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBar : MonoBehaviour
{
    [SerializeField]
    private float waitTime;
    public Text textValue;
    public bool isAuto;
    public bool isFill;
    public float value;
    public Image cooldown;
    public MainMoney mainMoney;

    // Update is called once per frame
    void Update()
    {
        if(cooldown.fillAmount < 1 && isFill){
            Isi();
            if(cooldown.fillAmount == 1 && isAuto){
                mainMoney.money += value;
                Reset();
                isFill = true;
            }else if(cooldown.fillAmount == 1){
                mainMoney.money += value;
                Reset();
                mainMoney.bukatoko.gameObject.SetActive(true);
                isFill = false;
            }
        }
        
        textValue.text = value.ToString();
        // Reset();
    }

    public void Isi(){
        cooldown.fillAmount += 1.0f / waitTime * Time.deltaTime;
    }

    public void Reset(){
        cooldown.fillAmount = 0;
    }
}
