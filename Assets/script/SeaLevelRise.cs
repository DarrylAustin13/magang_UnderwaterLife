using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SeaLevelRise : MonoBehaviour
{
    public Text SeaLevelText;
    private static int SeaLevel = 1;
    public Text DayNum;
    public static int Day = 1;
    public static int money = 10000;
    private int MoneyNee = 300000;
    private int moneyTimerUpgrade = 50000;
    private int moneyPowerUpgrade = 50000;
    public Text MoneyAmount;
    public Text MoneyToClean;
    public Text MoneyToProLong;
    public Text MoneyToMorePower;
    public TextMeshProUGUI TrashCollect;
    public static int TrashFillL = 25;
    public static int TrashFill = 25;
    public static float MoreTime = 20;
    public static float MorePower = 0f;
    [SerializeField] GameObject CleanReady;
    
    // Start is called before the first frame update
    void Start()
    {
        
        SeaLevelText.text = "Sea Lv " + SeaLevel;
        DayNum.text = "Day " + Day;
        MoneyAmount.text = "Rp " + money;
        MoneyToProLong.text = "Rp " + moneyTimerUpgrade;
        MoneyToMorePower.text = "Rp " + moneyPowerUpgrade;
        
        
        
    }

    void Update()
    {
        TrashCollect.text = "Trash Needed To Clean: " + TrashFill;
        MoneyToClean.text = "Money needed = " + MoneyNee;
    }
    public void CleanTheSea()
    {
        if( TrashFill == 0)
        {
            if(money < MoneyNee)
            {
                MoneyToClean.text = "Money not enough. Need= " + MoneyNee;
            }
            else
            {
                SeaLevel += 1;
                TrashFillL += 20;
                TrashFill = TrashFillL;
                money -= MoneyNee;
                MoneyNee += (SeaLevel * 15000);
                SeaLevelText.text = "Sea lv " + SeaLevel;
                MoneyAmount.text = "Rp " + money;
                TrashCollect.text = "Trash Needed To Clean: " + TrashFill;
            }
                
        }
    }

    public void UpgradeTime()
    {
        if (money >= moneyTimerUpgrade) 
        {
            MoreTime += 10;
            money -= moneyTimerUpgrade;
            moneyTimerUpgrade += 5000;
            MoneyAmount.text = "Rp " + money;
            MoneyToProLong.text = "Rp " + moneyTimerUpgrade;
        }
        
    }

    public void UpgradeHarpoon()
    {
        if(money >= moneyPowerUpgrade)
        {
            MorePower += 1.5f ;
            money -= moneyPowerUpgrade;
            moneyPowerUpgrade += 5000;
            MoneyAmount.text = "Rp " + money;
            MoneyToMorePower.text = "Rp " + moneyPowerUpgrade;
        }
    }

    public void EnterSea()
    {
        string SeaDiving = "Diving Lv " + SeaLevel;
        SceneManager.LoadScene(SeaDiving);
        HarpoonScriptChange.shoot = false;
    }

}
