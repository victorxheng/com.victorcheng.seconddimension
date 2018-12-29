using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Sdkbox;

public class ShopSelection : MonoBehaviour {
    public TextMeshProUGUI DescriptionText;

    public List<int[]> priceChart = new List<int[]>();
    public List<int[]> purchaseChart = new List<int[]>();

    string Tier = "Tier";

    public TextMeshProUGUI refillHealthText;

    public GameObject healthRefillGameObject;
    public GameObject purchaseButton;
    public TextMeshProUGUI purchaseText;
    public IAP iap;

    private void Awake()
    {
       /*
        PlayerPrefs.SetInt("Tier1", 0);
        PlayerPrefs.SetInt("Tier2", 0);
        PlayerPrefs.SetInt("Tier3", 0);
        PlayerPrefs.SetInt("Tier4", 0);
        PlayerPrefs.SetInt("Tier5", 0);

        PlayerPrefs.SetInt("maxHealth", 10);
        PlayerPrefs.SetInt("fireRate", 12);
        PlayerPrefs.SetInt("bulletSpeed", 20);
        PlayerPrefs.SetInt("moveSpeed", 12);
        PlayerPrefs.SetInt("cashDrop", 0);*/
        
       //PlayerPrefs.SetInt("cashAmount", 10000);
        int[] price = new int[] { 20,25,30,35,40,45,50,60,80,100,120,150,180,220,0 }; //i = 0 (refill health)
        priceChart.Add(price);
        int[] purchase = new int[] { 1 }; //i = 0 (refill health) (null)
        purchaseChart.Add(purchase);

        price = new int[] { 200 ,300,400,600,850,1000,1300,1600,2000,2400,3000,3700,4500,0}; //i = 1 (max health)
        priceChart.Add(price);
        purchase = new int[] { 11 ,12,13,14,15,16,18,20,22,24,26,28,30,0}; //i = 1 (max health)
        purchaseChart.Add(purchase);

        price = new int[] { 250, 350, 500, 750, 1000,1200,1500,1800,2200,2700,3300,4000,4800,5600,7000,0 }; //i = 2 (fire rate)
        priceChart.Add(price);
        purchase = new int[] { 13, 14, 15, 16, 17, 18,20,22,24,26,28,30,33,36,40,0 }; //i = 2 (fire rate)
        purchaseChart.Add(purchase);

        price = new int[] { 200, 300, 450, 600, 850,1000,1200,1500,1800,2200, 2600,3000,3500,4000,0 }; //i = 3 (bullet speed)
        priceChart.Add(price);
        purchase = new int[] { 21, 22, 23, 24, 25, 26,28,30,31,32,34,36,38,40,0}; //i = 3 (bullet speed)
        purchaseChart.Add(purchase);

        price = new int[] { 200, 300, 500, 800, 1200, 1700,2300,3000,0 }; //i = 4 (move rate)
        priceChart.Add(price);
        purchase = new int[] { 13, 14, 15, 16, 17, 18,19,20,0 }; //i = 4 (move rate)
        purchaseChart.Add(purchase);

        price = new int[] { 400, 600, 1200, 2000, 2800, 4000,0}; //i = 5 (cash)
        priceChart.Add(price);
        purchase = new int[] { 1, 2, 3, 4, 5,6,0 }; //i = 5 (cash rate)
        purchaseChart.Add(purchase);
        

    }

    public void openShop()
    {
        DescriptionText.text = "WELCOME TO THE SHOP!\n\nTHIS IS WHERE CASH IS SPENT \n \nCLICK AROUND TO VIEW AND PURCHASE UPGRADES";

        PlayerPrefs.SetInt("currentShopIndex", 0);
        purchaseButton.SetActive(false);
    }

    public void inAppPurchaseShow()
    {
        purchaseText.text ="$3.99 (USD)";//set text to price
        DescriptionText.text = "REMOVE ADS\n\nREMOVE POP-UP ADS BY SUPPORTING THE DEVELOPER! HELP MAKE A DIFFERENCE IN SOMEONE'S LIFE FOR A PRICE LESS THAN COFFEE!\n\nREMOVES POP-ADS BUT STILL PROVIDES REWARD-ADS (FOR REVIVES)";
        PlayerPrefs.SetInt("currentShopIndex", 6);
        purchaseButton.SetActive(true);
    }

    public void refillHealthShow()
    {
        Awake();
        int currentTier = PlayerPrefs.GetInt(Tier + "1", 0);//check for tier
        int[] currentPriceChart = priceChart[0]; //get price list
        int currentPrice = currentPriceChart[currentTier]; //get price from list using tier
        refillHealthText.text = currentPrice + " CASH";//set text to price
    }
    public void refillHealthClick()
    {
        int currentTier = PlayerPrefs.GetInt(Tier + "1", 0);//check for tier
        int[] currentPriceChart = priceChart[0]; //get price list
        int currentPrice = currentPriceChart[currentTier]; //get price from list using tier

        if(PlayerPrefs.GetInt("cashAmount", 0) < currentPrice) //checks for enough cash
        {
            refillHealthText.text = "NOT ENOUGH CASH";
        }
        else
        {
            PlayerPrefs.SetInt("cashAmount", PlayerPrefs.GetInt("cashAmount", 0) - currentPrice);//subtract price from cash
            
            PlayerPrefs.SetInt("playerHealth", PlayerPrefs.GetInt("maxHealth", 10));// change to max health
            PlayerPrefs.SetInt("waveHealth", PlayerPrefs.GetInt("playerHealth", 10));
            healthRefillGameObject.SetActive(false);
        }
    }

    public void buttonClick(int i)
    {
        int currentTier = PlayerPrefs.GetInt(Tier+i, 0);//check for tier
        int[] currentPriceChart = priceChart[i]; //get price list
        int[] currentPurchaseChart = purchaseChart[i]; //get purchase list

        int currentPrice = currentPriceChart[currentTier]; //get price from list using tier
        int currentPurchase = currentPurchaseChart[currentTier]; //get purchase from list using tier

        if(currentPrice == 0)PlayerPrefs.SetInt("currentShopIndex", 0);
        else PlayerPrefs.SetInt("currentShopIndex", i);
        purchaseButton.SetActive(true);

        switch (i)
        {
            case 1:
                if (currentPrice != 0) {
                    DescriptionText.text = "MAXIMUM HEALTH: \n\nINCREASE THE MAXIMUM AMOUNT OF HEALTH YOU CAN HAVE \n\nCURRENT TIER: " + (currentTier + 1) + "\n\nNEXT TIER COST: " + currentPrice + " CASH \n\nCURRENT MAX HEALTH: " + PlayerPrefs.GetInt("maxHealth", 10) + " HEALTH\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = currentPrice + " CASH (+" +(currentPurchase-PlayerPrefs.GetInt("maxHealth", 10)) + " MAX HEALTH)";
                }
                else
                {
                   DescriptionText.text = "MAXIMUM HEALTH: \n\nINCREASE THE MAXIMUM AMOUNT OF HEALTH YOU CAN HAVE \n\nCURRENT TIER: " + (currentTier + 1) + " (MAXED OUT)" + "\n\nCURRENT MAX HEALTH: " + PlayerPrefs.GetInt("maxHealth", 10) + " HEALTH\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                   purchaseText.text = "MAX TIER REACHED";
                }
                break;
            case 2:
                if (currentPrice != 0)
                {
                    DescriptionText.text = "FIRE RATE: \n\nINCREASE THE RATE AT WHICH YOU CAN SHOOT\n\nCURRENT TIER: " + (currentTier + 1) + "\n\nNEXT TIER COST: " + currentPrice + " CASH \n\nCURRENT RATE: " + PlayerPrefs.GetInt("fireRate", 12) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = currentPrice + " CASH (+" + (currentPurchase - PlayerPrefs.GetInt("fireRate", 12)) + " RATE)";
                }
                else
                {
                    DescriptionText.text = "FIRE RATE: \n\nINCREASE THE RATE AT WHICH YOU CAN SHOOT\n\nCURRENT TIER: " + (currentTier + 1)+" (MAXED OUT)" + "\n\nCURRENT RATE: " + PlayerPrefs.GetInt("fireRate", 12) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = "MAX TIER REACHED";
                }
                break;
            case 3:
                if (currentPrice != 0)
                {
                    DescriptionText.text = "BULLET TRAVEL SPEED: \n\nINCREASE HOW FAST YOUR BULLETS TRAVELS\n\nCURRENT TIER: " + (currentTier + 1) + "\n\nNEXT TIER COST: " + currentPrice + " CASH \n\nCURRENT SPEED: " + PlayerPrefs.GetInt("bulletSpeed", 20) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = currentPrice + " CASH (+" + (currentPurchase - PlayerPrefs.GetInt("bulletSpeed", 20)) + " SPEED)";
                }
                else
                {
                    DescriptionText.text = "BULLET TRAVEL SPEED: \n\nINCREASE HOW FAST YOUR BULLETS TRAVELS\n\nCURRENT TIER: " + (currentTier + 1) +" (MAXED OUT)" + "\n\nCURRENT SPEED: " + PlayerPrefs.GetInt("bulletSpeed", 20) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = "MAX TIER REACHED";
                }
                break;
            case 4:
                if (currentPrice != 0)
                {
                    DescriptionText.text = "MOVEMENT SPEED: \n\nINCREASE HOW FAST YOU TRAVEL\n\nCURRENT TIER: " + (currentTier + 1) + "\n\nNEXT TIER COST: " + currentPrice + " CASH \n\nCURRENT SPEED: " + PlayerPrefs.GetInt("moveSpeed", 12) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = currentPrice + " CASH (+" + (currentPurchase - PlayerPrefs.GetInt("moveSpeed", 12)) + " SPEED)";
                }
                else
                {
                    DescriptionText.text = "MOVEMENT SPEED: \n\nINCREASE HOW FAST YOU TRAVEL\n\nCURRENT TIER: " + (currentTier + 1) + " (MAXED OUT)" + "\n\nCURRENT SPEED: " + PlayerPrefs.GetInt("moveSpeed", 12) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = "MAX TIER REACHED";
                }
                break;
            case 5:
                if (currentPrice != 0)
                {
                    DescriptionText.text = "CASH DROP RATE: \n\nINCREASE HOW HOW MUCH CASH IS DROPPED\n\nCURRENT TIER: " + (currentTier + 1) + "\n\nNEXT TIER COST: " + currentPrice + " CASH \n\nCURRENT INCREASE: " + PlayerPrefs.GetInt("cashDrop", 0) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = currentPrice + " CASH (+" + (currentPurchase - PlayerPrefs.GetInt("cashDrop", 0)) + " INCREASE)";
                }
                else
                {
                    DescriptionText.text = "CASH DROP RATE: \n\nINCREASE HOW HOW MUCH CASH IS DROPPED\n\nCURRENT TIER: " + (currentTier + 1) + " (MAXED OUT)" + "\n\nCURRENT INCREASE: " + PlayerPrefs.GetInt("cashDrop", 0) + "\n\nCASH: " + PlayerPrefs.GetInt("cashAmount", 0);
                    purchaseText.text = "MAX TIER REACHED";
                }
                break;
                
        }
    }

    public void purchaseClick()
    {
        int index = PlayerPrefs.GetInt("currentShopIndex", 0);
        if (index != 6)
        {
            if (index != 0)
            {
                int currentTier = PlayerPrefs.GetInt(Tier + index, 0);//check for tier
                int[] currentPriceChart = priceChart[index]; //get price list
                int[] currentPurchaseChart = purchaseChart[index]; //get purchase list

                int currentPrice = currentPriceChart[currentTier]; //get price from list using tier
                int currentPurchase = currentPurchaseChart[currentTier]; //get purchase from list using tier

                if (PlayerPrefs.GetInt("cashAmount", 0) < currentPrice)
                {
                    purchaseText.text = "NOT ENOUGH CASH";
                }
                else
                {
                    switch (index)
                    {
                        case 1://max health
                            PlayerPrefs.SetInt("cashAmount", PlayerPrefs.GetInt("cashAmount", 0) - currentPrice);
                            PlayerPrefs.SetInt("maxHealth", currentPurchase);
                            PlayerPrefs.SetInt("playerHealth", PlayerPrefs.GetInt("maxHealth", 10));
                            PlayerPrefs.SetInt(Tier + index, currentTier + 1);//increase tier
                            PlayerPrefs.SetInt(Tier + (index - 1), currentTier + 1);//increase tier
                            buttonClick(index);
                            break;

                        case 2://fire rate
                            PlayerPrefs.SetInt("cashAmount", PlayerPrefs.GetInt("cashAmount", 0) - currentPrice);
                            PlayerPrefs.SetInt("fireRate", currentPurchase);
                            PlayerPrefs.SetInt(Tier + index, currentTier + 1);//increase tier
                            buttonClick(index);
                            break;

                        case 3://bullet speed
                            PlayerPrefs.SetInt("cashAmount", PlayerPrefs.GetInt("cashAmount", 0) - currentPrice);
                            PlayerPrefs.SetInt("bulletSpeed", currentPurchase);
                            PlayerPrefs.SetInt(Tier + index, currentTier + 1);//increase tier
                            buttonClick(index);
                            break;

                        case 4://moveSpeed
                            PlayerPrefs.SetInt("cashAmount", PlayerPrefs.GetInt("cashAmount", 0) - currentPrice);
                            PlayerPrefs.SetInt("moveSpeed", currentPurchase);
                            PlayerPrefs.SetInt(Tier + index, currentTier + 1);//increase tier
                            buttonClick(index);
                            break;

                        case 5://cashDrop
                            PlayerPrefs.SetInt("cashAmount", PlayerPrefs.GetInt("cashAmount", 0) - currentPrice);
                            PlayerPrefs.SetInt("cashDrop", currentPurchase);
                            PlayerPrefs.SetInt(Tier + index, currentTier + 1);//increase tier
                            buttonClick(index);
                            break;

                    }
                }
            }
        }
        else
        {
            iap.purchase("Remove Ads");
        }
        
    }

}
