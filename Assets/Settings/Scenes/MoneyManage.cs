using UnityEngine;
using TMPro;

public class MoneyManage : MonoBehaviour
{
    public float money = 0f; // the current money
    public float moneyPerSecond = 1f; // base money per second4
    public TextMeshProUGUI moneyText;

    void Update()
    {
        money += moneyPerSecond * Time.deltaTime; // increases money every second

        if (moneyText != null)
        {
            moneyText.text = "money: " + Mathf.FloorToInt(money).ToString();
        }
    
    }
    public void Upgrade()
    {
        float upgradeCost = 10f;
        if (money >= upgradeCost)
        {
            money -= upgradeCost;
            moneyPerSecond *= 2;
        }
    }
   
}
