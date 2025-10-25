using UnityEngine;
using TMPro;
using System.Collections;

public class MoneyManage : MonoBehaviour
{
    public int money = 0; // the current money
    public int moneyPerSecond = 1; // base money per second4
    public TextMeshProUGUI moneyText;
    public int upgradeCost = 10;

    void Start()
    {
        StartCoroutine(WaitTime());
    }
    void Update()
    {

        if (moneyText != null)
        {
            moneyText.text = "money: " + Mathf.FloorToInt(money).ToString();
        }
    
    }
    public void Upgrade()
    {
        
        if (money >= upgradeCost)
        {
            money -= upgradeCost;
            moneyPerSecond += 1;
            
        }
    }
    public IEnumerator WaitTime()
    {
        while (true)
        
        {
            yield return new WaitForSeconds(1);
            money += moneyPerSecond;
            

        }
        yield return null;
       
        


    }
   
}
