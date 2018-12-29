using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Advertisements;

public class waveFramework : MonoBehaviour {

    public List<List<string>> waveList = new List<List<string>>();
    public EnemySpawn es;
    public TextMeshProUGUI waveText;
    public GameObject WaveTextGO;
    public TextMeshProUGUI waveActiveText;
    public GameObject refillHealth;

    public ShopSelection ss;
    public TutorialSingle ts;

    public void onPlay()
    {
        //PlayerPrefs.SetInt("waveNumber", 0);//149 => 155 (add six to rounds past 40)
        //To Be Deleted

        //FIRST ENTRY IS ALWAYS WAVE DURATION 
        // 1 2 3 4 (seconds: 0300 for five minute wave)

        // 1 2 _ 3 _ 4 5 6 7 8 _ 9 10 11 _ 12 13 14
        //1 2: Enemy Type (0 for standard)
        //3 Spawn Location (0 for standard)
        //4 5 6 7 8: Spawn Speed in 0.01 Seconds (00020 to 00100 for 0.2 seconds per spawn to 1 second per spawn)
        //9 10 11: Spawn Duration in Seconds (use 060 for a 1 minute wave)
        //12 13 14: Spawn Delay in Seconds (use 000 for no delay, 060 for a 60 second delay)

        //rounds
        List<string> round = new List<string>();

        round = new List<string>();//0
        round.Add("00 0 00100 010 002");
        round.Add("t 00 01 <= MOVE FINGER HERE TO MOVE AROUND");
        round.Add("t 04 01 MOVE FINGER HERE TO SHOOT ENEMIES=>");
        round.Add("t 10 03 SECOND DIMENSION");
        waveList.Add(round);

        round = new List<string>();//1
        round.Add("00 0 00100 015 020");
        round.Add("t 04 04 IN THE YEAR 2738, HUMANS \nDEVELOPED EXTRADIMENSIONAL PORTALS");
        round.Add("t 11 04 YOU HAVE ENTERED ONE, \nLAUNCHING YOU INTO ANOTHER WORLD");
        round.Add("t 18 04 YOU HAVE ENTERED THE SECOND DIMENSION");
        round.Add("t 25 04 SURVIVE.");
        waveList.Add(round);

        round = new List<string>();//2
        round.Add("00 0 00090 010 000");
        round.Add("t 00 02 EACH ENEMY DROPS CASH WHEN IT DIES");
        round.Add("t 05 02 IT CAN DROP BETWEEN 0 TO 3 CASH");
        round.Add("t 10 02 CASH CAN BE SPENT IN THE \nSHOP FOR UPGRADES");
        waveList.Add(round);

        round = new List<string>();//3
        round.Add("00 0 00070 015 000");
        round.Add("t 00 02 AS MORE WAVES PASS, NEW ENEMIES\nWILL BE INTRODUCED");
        round.Add("t 05 04 THERE WILL BE ARMORED ENEMIES, SPLITTING \nENEMIES, SHOOTING ENEMIES, AND MORE");
        waveList.Add(round);

        round = new List<string>();//4
        round.Add("01 0 00120 010 000");
        round.Add("t 00 03 WATCH OUT - FASTER ENEMIES INCOMING");
        waveList.Add(round);

        round = new List<string>();//5
        round.Add("01 0 00180 010 000");
        round.Add("00 0 00160 009 001");
        round.Add("t 00 02 IN THE SHOP, YOU CAN UPGRADE YOUR MAX HEALTH");
        round.Add("t 05 03 HOWEVER, HEALTH REFILLS WILL COST MORE\nWHEN YOU UPGRADE");
        waveList.Add(round);

        round = new List<string>();//6
        round.Add("01 0 00160 010 000");
        round.Add("00 0 00150 009 001");
        round.Add("t 00 02 YOU CAN ALSO UPGRADE YOUR FIRE RATE");
        round.Add("t 05 02 THIS ALLOWS YOU TO SHOOT AT A FASTER SPEED");
        waveList.Add(round);

        round = new List<string>();//7
        round.Add("00 0 00050 015 000");
        round.Add("t 00 03 UPGRADING BULLET SPEED INCREASES\nHOW FAST YOUR BULLETS TRAVEL");
        round.Add("t 06 02 THIS USEFUL FOR ACCURATE SHOTS");
        waveList.Add(round);

        round = new List<string>();//8
        round.Add("01 0 00060 015 000");
        round.Add("t 00 02 THE SHOP CAN ALSO UPGRADE YOUR MOVE SPEED");
        round.Add("t 05 02 THIS ALLOWS YOU TO MOVE FASTER");
        round.Add("t 10 02 IT MAKES IT EASIER TO JUKE OUT ENEMIES");
        waveList.Add(round);

        round = new List<string>();//8
        round.Add("01 0 00060 015 000");
        round.Add("t 00 02 FINALLY, YOU CAN UPGRADE YOUR \nCASH DROP RATE");
        round.Add("t 05 02 THIS INCREASES HOW MUCH CASH ENEMIES DROP");
        waveList.Add(round);

        round = new List<string>();//9
        round.Add("t 00 02 GOOD LUCK!");
        round.Add("00 0 00100 020 000");
        round.Add("01 0 00070 003 006");
        round.Add("01 0 00070 003 012");
        round.Add("01 0 00070 003 019");
        waveList.Add(round);

        round = new List<string>();//10
        round.Add("t 00 03 NEW ENEMIES WAVE 26");
        round.Add("00 0 00100 020 000");
        round.Add("01 0 00070 003 006");
        round.Add("01 0 00070 003 012");
        round.Add("01 0 00070 003 019");
        waveList.Add(round);

        round = new List<string>();//11
        round.Add("00 0 00040 020 000");
        waveList.Add(round);


        round = new List<string>();//12
        round.Add("00 0 00030 025 000");
        waveList.Add(round);


        round = new List<string>();//13
        round.Add("01 0 00045 020 000");
        waveList.Add(round);

        round = new List<string>();//14
        round.Add("01 0 00040 025 000");
        waveList.Add(round);


        round = new List<string>();//15
        round.Add("01 0 00075 020 000");
        round.Add("00 0 00075 020 000");
        waveList.Add(round);

        round = new List<string>();//16
        round.Add("01 0 00040 025 000");
        waveList.Add(round);

        round = new List<string>();//17
        round.Add("01 0 00060 020 000");
        round.Add("00 0 00060 020 000");
        waveList.Add(round);

        round = new List<string>();//18
        round.Add("01 0 00050 025 000");
        round.Add("00 0 00055 025 000");
        waveList.Add(round);

        round = new List<string>();//19
        round.Add("00 0 00030 020 000");
        waveList.Add(round);

        round = new List<string>();//20
        round.Add("01 0 00035 020 000");
        waveList.Add(round);

        round = new List<string>();//21
        round.Add("00 0 00025 030 000");
        waveList.Add(round);

        round = new List<string>();//22
        round.Add("01 0 00030 025 000");
        waveList.Add(round);

        round = new List<string>();//23
        round.Add("01 0 00025 030 000");
        waveList.Add(round);

        round = new List<string>();//24
        round.Add("01 0 00024 030 000");
        waveList.Add(round);

        round = new List<string>();//25
        round.Add("02 0 00100 010 000");
        round.Add("t 00 03 ARMORED ENEMIES INCOMING");
        round.Add("t 06 03 EACH LAYER OF ARMOR TAKES IN \nMORE DAMAGE");
        waveList.Add(round);

        round = new List<string>();//26
        round.Add("02 0 00080 015 000");
        waveList.Add(round);

        round = new List<string>();//27
        round.Add("02 0 00100 020 000");
        round.Add("00 0 00050 020 000");
        waveList.Add(round);

        round = new List<string>();//28
        round.Add("02 0 00080 020 000");
        round.Add("01 0 00060 020 000");
        waveList.Add(round);

        round = new List<string>();//29
        round.Add("02 0 00070 020 000");
        round.Add("01 0 00070 020 000");
        waveList.Add(round);

        round = new List<string>();//30
        round.Add("02 0 00040 020 000");
        waveList.Add(round);

        round = new List<string>();//31
        round.Add("02 0 00035 020 000");
        round.Add("00 0 00150 020 000");
        waveList.Add(round);

        round = new List<string>();//30
        round.Add("02 0 00030 020 000");
        waveList.Add(round);

        round = new List<string>();//31
        round.Add("02 0 00030 025 000");
        round.Add("00 0 00150 025 000");
        waveList.Add(round);

        round = new List<string>();//30
        round.Add("02 0 00025 020 000");
        waveList.Add(round);

        round = new List<string>();//30
        round.Add("02 0 00025 025 000");
        waveList.Add(round);

        round = new List<string>();//31
        round.Add("01 0 00025 025 000");
        round.Add("02 0 00150 030 000");
        waveList.Add(round);

        round = new List<string>();//32
        round.Add("01 0 00025 030 000");
        round.Add("02 0 00120 030 000");
        waveList.Add(round);

        round = new List<string>();//33
        round.Add("01 0 00030 030 000");
        round.Add("02 0 00100 030 000");
        waveList.Add(round);

        round = new List<string>();//34
        round.Add("02 0 00030 030 000");
        round.Add("01 0 00100 030 000");
        waveList.Add(round);

        round = new List<string>();//35
        round.Add("02 0 00020 030 000");
        waveList.Add(round);

        round = new List<string>();//36
        round.Add("02 0 00020 030 000");
        waveList.Add(round);

        round = new List<string>();//37
        round.Add("03 0 00120 010 000");
        round.Add("t 00 03 GREEN ENEMIES INCOMING");
        waveList.Add(round);

        round = new List<string>();//38
        round.Add("03 0 00120 020 000");
        waveList.Add(round);

        round = new List<string>();//39
        round.Add("03 0 00105 015 000");
        waveList.Add(round);

        round = new List<string>();//40
        round.Add("01 0 00060 005 000");
        round.Add("02 0 00070 005 007");
        round.Add("03 0 00080 005 014");
        waveList.Add(round);

        round = new List<string>();//41
        round.Add("00 0 00045 005 000");
        round.Add("01 0 00060 005 007");
        round.Add("02 0 00070 007 014");
        round.Add("03 0 00080 008 023");
        waveList.Add(round);

        round = new List<string>();//42
        round.Add("00 0 00040 020 000");
        round.Add("03 0 00100 020 000");
        waveList.Add(round);

        round = new List<string>();//43
        round.Add("01 0 00040 020 000");
        round.Add("03 0 00100 020 000");
        waveList.Add(round);

        round = new List<string>();//44
        round.Add("02 0 00060 020 000");
        round.Add("03 0 00070 020 000");
        waveList.Add(round);

        round = new List<string>();//45
        round.Add("01 0 00080 025 000");
        round.Add("02 0 00090 025 005");
        round.Add("03 0 00100 025 010");
        waveList.Add(round);

        round = new List<string>();//46
        round.Add("01 0 00050 020 000");
        round.Add("00 0 00040 020 000");
        waveList.Add(round);

        round = new List<string>();//47
        round.Add("01 0 00018 015 000");
        waveList.Add(round);

        round = new List<string>();//48
        round.Add("02 0 00025 020 000");
        waveList.Add(round);

        round = new List<string>();//49
        round.Add("02 0 00024 025 000");
        waveList.Add(round);

        round = new List<string>();//50
        round.Add("03 0 00030 025 000");
        waveList.Add(round);


        round = new List<string>();//51
        round.Add("t 00 03 GOOD LUCK");
        round.Add("03 0 00025 030 000");
        round.Add("01 0 00040 005 005");
        round.Add("01 0 00040 005 025");
        round.Add("02 0 00050 005 000");
        round.Add("02 0 00050 005 020");
        waveList.Add(round);

        round = new List<string>();//52
        round.Add("04 0 00200 010 000");
        round.Add("t 00 03 SPLITTING ENEMIES INCOMING");
        waveList.Add(round);

        round = new List<string>();//53
        round.Add("04 0 00180 010 000");
        round.Add("t 00 03 THESE CYAN ENEMIES SPLIT INTO\nTWO GREEN ONES");
        waveList.Add(round);

        round = new List<string>();//54
        round.Add("t 00 03 IT DOESN'T MATTER WHICH ENEMYHURTS YOU, \nTHEY ALL DEAL THE SAME DAMAGE");
        round.Add("04 0 00175 020 000");
        waveList.Add(round);

        round = new List<string>();//55
        round.Add("00 0 00080 025 000");
        round.Add("04 0 00175 025 000");
        waveList.Add(round);

        round = new List<string>();//56
        round.Add("02 0 00080 025 000");
        round.Add("04 0 00150 025 000");
        waveList.Add(round);

        round = new List<string>();//57
        round.Add("03 0 00080 025 000");
        round.Add("04 0 00175 025 000");
        waveList.Add(round);

        round = new List<string>();//58
        round.Add("03 0 00080 025 000");
        round.Add("04 0 00175 025 000");
        waveList.Add(round);

        round = new List<string>();//59
        round.Add("04 0 00150 020 000");
        waveList.Add(round);        

        round = new List<string>();//60
        round.Add("01 0 00060 005 000");
        round.Add("02 0 00070 005 007");
        round.Add("03 0 00080 005 014");
        waveList.Add(round);

        round = new List<string>();//61
        round.Add("00 0 00045 005 000");
        round.Add("01 0 00060 005 007");
        round.Add("02 0 00070 007 014");
        round.Add("03 0 00080 008 023");
        round.Add("04 0 00150 010 032");
        waveList.Add(round);

        round = new List<string>();//62
        round.Add("00 0 00050 020 000");
        round.Add("04 0 00150 020 000");
        waveList.Add(round);
    
        round = new List<string>();//63
        round.Add("03 0 00050 020 000");
        round.Add("04 0 00150 020 000");
        waveList.Add(round);

        round = new List<string>();//64
        round.Add("02 0 00050 020 000");
        round.Add("01 0 00050 020 000");
        waveList.Add(round);

        round = new List<string>();//65
        round.Add("01 0 00080 025 000");
        round.Add("04 0 00150 025 005");
        round.Add("03 0 00100 025 010");
        waveList.Add(round);

        round = new List<string>();//66
        round.Add("01 0 00050 020 000");
        round.Add("00 0 00040 020 000");
        waveList.Add(round);

        round = new List<string>();//67
        round.Add("04 0 00100 015 000");
        waveList.Add(round);

        round = new List<string>();//68
        round.Add("03 0 00100 020 000");
        round.Add("04 0 00100 020 000");
        waveList.Add(round);

        round = new List<string>();//69
        round.Add("04 0 00075 025 000");
        waveList.Add(round);

        round = new List<string>();//70
        round.Add("03 0 00030 010 000");
        round.Add("04 0 00070 015 011");
        waveList.Add(round);

        round = new List<string>();//71
        round.Add("00 0 00045 005 000");
        round.Add("01 0 00050 005 007");
        round.Add("02 0 00060 007 014");
        round.Add("03 0 00070 008 023");
        round.Add("04 0 00070 010 032");
        waveList.Add(round);

        round = new List<string>();//72
        round.Add("04 0 00060 020 000");
        waveList.Add(round);

        round = new List<string>();//73
        round.Add("00 0 00100 025 000");
        round.Add("04 0 00100 025 005");
        round.Add("03 0 00120 025 010");
        waveList.Add(round);

        round = new List<string>();//74
        round.Add("02 0 00100 020 000");
        round.Add("04 0 00060 010 020");
        round.Add("03 0 00120 020 000");
        waveList.Add(round);

        round = new List<string>();//75
        round.Add("05 0 00050 020 000");
        waveList.Add(round);

        round = new List<string>();//76
        round.Add("t 00 03 NEXT ROUND: DARK BLUE ENEMIES");
        round.Add("04 0 00070 030 000");
        round.Add("01 0 00040 005 005");
        round.Add("01 0 00040 005 025");
        round.Add("03 0 00050 005 000");
        round.Add("03 0 00050 005 020");
        waveList.Add(round);

        round = new List<string>();//77
        round.Add("t 00 03 DARK BLUE ENEMIES INCOMING");
        round.Add("t 05 03 THIS LAYER IS AN ARMOR LAYER \nFOR THE CYAN ENEMY");
        round.Add("05 0 00180 015 000");
        waveList.Add(round);

        round = new List<string>();//78
        round.Add("05 0 00150 020 000");
        waveList.Add(round);

        round = new List<string>();//79
        round.Add("00 0 00050 025 000");
        round.Add("05 0 00170 025 000");
        waveList.Add(round);

        round = new List<string>();//80
        round.Add("03 0 00080 025 000");
        round.Add("05 0 00150 025 000");
        waveList.Add(round);

        round = new List<string>();//81
        round.Add("04 0 00120 025 000");
        round.Add("05 0 00120 025 000");
        waveList.Add(round);

        round = new List<string>();//82
        round.Add("02 0 00080 025 000");
        round.Add("05 0 00120 025 000");
        waveList.Add(round);

        round = new List<string>();//83
        round.Add("05 0 00100 020 000");
        waveList.Add(round);

        round = new List<string>();//84
        round.Add("01 0 00020 005 000");
        round.Add("02 0 00030 005 007");
        round.Add("03 0 00030 005 014");
        waveList.Add(round);

        round = new List<string>();//85
        round.Add("00 0 00020 005 000");
        round.Add("01 0 00025 005 007");
        round.Add("02 0 00030 007 014");
        round.Add("03 0 00040 008 023");
        round.Add("04 0 00060 010 032");
        round.Add("05 0 00075 005 043");
        waveList.Add(round);
        

        round = new List<string>();//86
        round.Add("00 0 00100 025 000");
        round.Add("05 0 00100 025 005");
        round.Add("03 0 00100 025 010");
        waveList.Add(round);

        round = new List<string>();//87
        round.Add("02 0 00060 020 000");
        round.Add("05 0 00060 010 020");
        round.Add("03 0 00060 020 000");
        waveList.Add(round);


        round = new List<string>();//88
        round.Add("t 00 03 ARE YOU READY?");
        round.Add("05 0 00070 030 000");
        round.Add("01 0 00040 005 005");
        round.Add("01 0 00040 005 025");
        round.Add("03 0 00050 005 000");
        round.Add("03 0 00050 005 020");
        round.Add("06 0 00250 010 032");
        waveList.Add(round);


        round = new List<string>();//89
        round.Add("t 00 03 EACH PINK ENEMY SPLITS INTO\nFOUR BLUE ONES");
        round.Add("t 05 03 ENJOY!");
        round.Add("06 0 00200 010 000");
        waveList.Add(round);

        round = new List<string>();//90
        round.Add("06 0 00160 020 000");
        waveList.Add(round);

        round = new List<string>();//91
        round.Add("00 0 00020 005 000");
        round.Add("01 0 00020 005 007");
        round.Add("02 0 00020 007 014");
        round.Add("03 0 00040 008 023");
        round.Add("05 0 00060 010 032");
        round.Add("06 0 00170 005 043");
        waveList.Add(round);

        round = new List<string>();//92
        round.Add("06 0 00150 040 000");
        round.Add("05 0 00200 040 000");
        waveList.Add(round);

        round = new List<string>();//93
        round.Add("t 00 03 YOU'VE MADE IT TO WAVE 100");
        round.Add("06 0 00250 040 000");
        round.Add("01 0 00025 040 000");
        waveList.Add(round);

        round = new List<string>();//94
        round.Add("06 0 00250 040 000");
        round.Add("01 0 00025 040 000");
        round.Add("03 0 00100 020 020");
        waveList.Add(round);

        round = new List<string>();//95
        round.Add("03 0 00030 020 000");
        round.Add("06 0 00150 020 020");
        round.Add("01 0 00025 020 020");
        round.Add("05 0 00080 020 000");
        waveList.Add(round);

        round = new List<string>();//96
        round.Add("05 0 00080 030 000");
        round.Add("06 0 00200 030 000");
        round.Add("01 0 00030 040 000");
        waveList.Add(round);

        round = new List<string>();//97
        round.Add("00 0 00030 025 000");
        round.Add("06 0 00200 025 005");
        round.Add("04 0 00100 025 010");
        waveList.Add(round);

        round = new List<string>();//98
        round.Add("03 0 00025 010 000");
        round.Add("04 0 00040 010 010");
        round.Add("05 0 00050 010 020");
        round.Add("06 0 00150 010 030");
        waveList.Add(round);

        round = new List<string>();//99
        round.Add("t 05 03 DO YOU STILL HAVE THE WILL TO SURVIVE?");
        round.Add("06 0 00120 020 000");
        round.Add("03 0 00020 005 010");
        round.Add("06 0 00100 020 020");
        round.Add("03 0 00020 005 030");
        round.Add("07 0 00200 003 040");
        waveList.Add(round);

        round = new List<string>();//100
        round.Add("t 00 03 ENJOY THE RED GUYS?");
        round.Add("07 0 00500 06 005");
        round.Add("06 0 00150 10 000");
        waveList.Add(round);


        round = new List<string>();//101
        round.Add("06 0 00120 020 000");
        round.Add("03 0 00020 005 010");
        round.Add("06 0 00100 020 020");
        round.Add("03 0 00020 005 030");
        round.Add("07 0 00500 006 040");
        waveList.Add(round);

        round = new List<string>();//102
        round.Add("07 0 00500 020 005");
        round.Add("06 0 00100 030 000");
        round.Add("01 0 00035 030 000");
        waveList.Add(round);

        round = new List<string>();//103
        round.Add("t 00 03 EASY CASH?");
        round.Add("07 0 00200 025 000");
        waveList.Add(round);


        round = new List<string>();//104
        round.Add("05 0 00070 030 000");
        round.Add("07 0 00200 025 005");
        waveList.Add(round);

        round = new List<string>();//105
        round.Add("05 0 00050 030 000");
        round.Add("06 0 00100 025 005");
        waveList.Add(round);

        round = new List<string>();//106
        round.Add("00 0 00025 025 000");
        round.Add("07 0 00250 040 005");
        round.Add("05 0 00100 010 025");
        round.Add("06 0 00150 015 030");
        waveList.Add(round);

        round = new List<string>();//107
        round.Add("05 0 00070 025 000");
        round.Add("06 0 00100 025 000");
        round.Add("00 0 00020 020 025");
        round.Add("07 0 00200 003 040");
        waveList.Add(round);

        round = new List<string>();//108
        round.Add("07 0 00180 020 000");
        waveList.Add(round);

        round = new List<string>();//109
        round.Add("03 0 00025 010 000");
        round.Add("05 0 00050 005 010");
        round.Add("06 0 00100 005 015");
        round.Add("07 0 00200 020 020");
        waveList.Add(round);

        round = new List<string>();//110
        round.Add("03 0 00035 005 000");
        round.Add("04 0 00060 005 007");
        round.Add("05 0 00070 007 014");
        round.Add("06 0 00100 008 023");
        round.Add("07 0 00150 010 032");
        waveList.Add(round);

        round = new List<string>();//111
        round.Add("03 0 00025 010 000");
        round.Add("04 0 00050 005 010");
        round.Add("05 0 00100 005 015");
        round.Add("06 0 00200 020 020");
        round.Add("03 0 00035 005 040");
        round.Add("04 0 00060 005 050");
        round.Add("05 0 00070 010 055");
        round.Add("06 0 00100 010 065");
        round.Add("07 0 00150 010 075");
        waveList.Add(round);

        round = new List<string>();//112
        round.Add("03 0 00030 020 000");
        round.Add("06 0 00080 020 020");
        round.Add("04 0 00040 020 020");
        round.Add("03 0 00030 020 040");
        waveList.Add(round);

        round = new List<string>();//113
        round.Add("00 0 00050 010 000");
        round.Add("03 0 00040 020 010");
        round.Add("01 0 00035 020 010");
        round.Add("07 0 00200 010 030");
        round.Add("00 0 00020 010 040");
        waveList.Add(round);

        round = new List<string>();//114
        round.Add("01 0 00040 025 000");
        round.Add("06 0 00150 025 005");
        round.Add("03 0 00050 025 010");
        round.Add("07 0 00200 005 035");
        waveList.Add(round);

        round = new List<string>();//115
        round.Add("00 0 00015 050 000");
        waveList.Add(round);

        round = new List<string>();//116
        round.Add("07 0 00170 040 000");
        waveList.Add(round);

        round = new List<string>();//117
        round.Add("00 0 00010 002 000");
        round.Add("07 0 00200 040 000");
        round.Add("00 0 00010 002 030");
        round.Add("04 0 00150 015 015");
        round.Add("04 0 00150 005 035");
        waveList.Add(round);

        round = new List<string>();//118
        round.Add("t 00 03 SHOOTING ENEMIES ROUND 132");
        round.Add("06 0 00070 040 000");
        round.Add("01 0 00015 005 015");
        round.Add("01 0 00015 003 030");
        round.Add("01 0 00015 005 040");
        waveList.Add(round);        

        round = new List<string>();//119
        round.Add("t 00 03 WARNING: LONG WAVE");
        round.Add("00 0 00010 002 000");
        round.Add("01 0 00020 012 003");
        round.Add("02 0 00025 015 015");
        round.Add("03 0 00030 020 030");
        round.Add("04 0 00050 010 050");
        round.Add("05 0 00060 010 060");
        round.Add("06 0 00070 020 070");
        round.Add("07 0 00180 020 090");
        round.Add("00 0 00010 002 110");
        waveList.Add(round);

        round = new List<string>();//120
        round.Add("00 0 00025 025 000");
        round.Add("07 0 00250 040 005");
        round.Add("05 0 00100 010 025");
        round.Add("06 0 00150 015 030");
        round.Add("00 0 00015 005 045");
        round.Add("07 0 00200 003 050");
        waveList.Add(round);

        round = new List<string>();//121
        round.Add("04 0 00050 030 000");
        round.Add("01 0 00020 005 005");
        round.Add("01 0 00020 005 025");
        round.Add("03 0 00040 005 000");
        round.Add("03 0 00040 005 020");
        round.Add("06 0 00060 020 030");
        round.Add("01 0 00025 010 050");
        waveList.Add(round);

        round = new List<string>();//122
        round.Add("00 0 00020 010 000");
        round.Add("03 0 00035 020 010");
        round.Add("01 0 00035 020 010");
        round.Add("07 0 00150 010 030");
        round.Add("00 0 00015 05 040");
        round.Add("00 0 00020 010 045");
        waveList.Add(round);

        round = new List<string>();//123
        round.Add("06 0 00080 020 000");
        round.Add("03 0 00020 005 010");
        round.Add("06 0 00070 020 020");
        round.Add("03 0 00020 005 030");
        round.Add("04 0 00050 020 040");
        round.Add("07 0 00500 060 000");
        waveList.Add(round);

        round = new List<string>();//124
        round.Add("t 00 03 PEW PEW PEW");
        round.Add("08 0 00200 020 000");
        waveList.Add(round);

        round = new List<string>();//125
        round.Add("t 00 03 ORANGE SHOOTING ENEMIES HAVE THE \nSAME HEALTH HAS YELLOW ONES");
        round.Add("08 0 00150 030 000");
        round.Add("01 0 00050 030 000");
        waveList.Add(round);

        round = new List<string>();//126
        round.Add("07 0 00500 060 000");
        round.Add("08 0 00150 010 000");
        round.Add("01 0 00050 010 010");
        round.Add("08 0 00150 010 020");
        round.Add("01 0 00050 010 030");
        round.Add("08 0 00150 010 040");
        round.Add("01 0 00050 010 050");
        waveList.Add(round);

        round = new List<string>();//127
        round.Add("03 0 00030 020 000");
        round.Add("08 0 00120 020 020");
        round.Add("07 0 00250 020 020");
        round.Add("03 0 00040 020 040");
        round.Add("01 0 00040 020 040");
        round.Add("01 0 00030 020 060");
        round.Add("08 0 00100 020 060");
        waveList.Add(round);

        round = new List<string>();//128
        round.Add("07 0 00500 030 000");
        round.Add("08 0 00120 030 000");
        round.Add("01 0 00035 030 000");
        round.Add("08 0 00105 030 030");
        round.Add("01 0 00045 010 050");
        waveList.Add(round);

        round = new List<string>();//129
        round.Add("t 00 03 ADDING ARMOR TO SHOOTERS?");
        round.Add("08 0 00100 020 000");
        round.Add("08 0 00200 020 020");
        round.Add("09 0 00250 020 020");
        waveList.Add(round);

        round = new List<string>();//130
        round.Add("09 0 00200 025 000");
        waveList.Add(round);

        round = new List<string>();//131
        round.Add("00 0 00010 002 000");
        round.Add("01 0 00020 012 003");
        round.Add("03 0 00030 020 015");
        round.Add("05 0 00060 010 035");
        round.Add("06 0 00070 020 055");
        round.Add("07 0 00180 020 075");
        round.Add("00 0 00010 002 095");
        round.Add("08 0 00120 010 097");
        round.Add("09 0 00200 010 107");
        waveList.Add(round);

        round = new List<string>();//132
        round.Add("00 0 00025 025 000");
        round.Add("07 0 00250 040 005");
        round.Add("05 0 00100 010 025");
        round.Add("08 0 00150 015 030");
        round.Add("00 0 00015 005 045");
        round.Add("09 0 00200 003 050");
        waveList.Add(round);

        round = new List<string>();//133
        round.Add("04 0 00050 030 000");
        round.Add("01 0 00035 005 005");
        round.Add("01 0 00035 005 025");
        round.Add("03 0 00040 005 000");
        round.Add("03 0 00040 005 020");
        round.Add("08 0 00100 020 030");
        round.Add("09 0 00185 010 050");
        waveList.Add(round);

        round = new List<string>();//134
        round.Add("00 0 00020 010 000");
        round.Add("09 0 00200 020 010");
        round.Add("01 0 00035 020 010");
        round.Add("07 0 00150 010 030");
        round.Add("08 0 00125 005 040");
        round.Add("09 0 00120 010 045");
        round.Add("01 0 00050 015 040");
        waveList.Add(round);

        round = new List<string>();//135
        round.Add("06 0 00080 020 000");
        round.Add("08 0 00120 005 010");
        round.Add("06 0 00070 020 020");
        round.Add("08 0 00120 005 030");
        round.Add("09 0 00200 020 040");
        round.Add("07 0 00500 060 000");
        waveList.Add(round);

        round = new List<string>();//136
        round.Add("t 00 03 RED ARMORED SHOOTING ENEMIES INCOMING");
        round.Add("10 0 00250 025 000");
        waveList.Add(round);

        round = new List<string>();//137
        round.Add("10 0 00250 040 000");
        round.Add("05 0 00100 040 000");
        round.Add("00 1 00010 002 010");
        round.Add("00 1 00010 002 020");
        round.Add("00 1 00010 002 030");
        waveList.Add(round);

        round = new List<string>();//138
        round.Add("08 0 00120 020 000");
        round.Add("09 0 00150 020 020");
        round.Add("10 0 00200 020 040");
        waveList.Add(round);


        round = new List<string>();//139
        round.Add("07 0 00500 060 000");
        round.Add("10 0 00250 010 000");
        round.Add("01 0 00050 010 010");
        round.Add("10 0 00250 010 020");
        round.Add("01 0 00050 010 030");
        round.Add("10 0 00250 010 040");
        round.Add("01 0 00050 010 050");
        waveList.Add(round);

        round = new List<string>();//140
        round.Add("03 0 00030 020 000");
        round.Add("08 0 00120 020 020");
        round.Add("07 0 00250 020 020");
        round.Add("03 0 00040 020 040");
        round.Add("01 0 00040 020 040");
        round.Add("01 0 00030 020 060");
        round.Add("10 0 00100 020 060");
        waveList.Add(round);

        round = new List<string>();//141
        round.Add("10 0 00400 030 000");
        round.Add("08 0 00120 030 000");
        round.Add("01 0 00035 030 000");
        round.Add("08 0 00105 030 030");
        round.Add("01 0 00045 010 050");
        waveList.Add(round);


        round = new List<string>();//142
        round.Add("06 0 00100 020 000");
        round.Add("10 0 00200 020 020");
        round.Add("08 0 00100 020 020");
        waveList.Add(round);

        round = new List<string>();//143
        round.Add("07 0 00200 004 000");
        round.Add("06 0 00300 010 000");
        round.Add("07 0 00200 004 020");
        round.Add("06 0 00300 010 020");
        round.Add("08 0 00100 050 000");
        round.Add("01 0 00035 050 000");
        waveList.Add(round);

        round = new List<string>();//144
        round.Add("10 0 00200 060 000");
        round.Add("01 0 00025 060 000");
        round.Add("08 0 00100 020 060");
        round.Add("03 0 00030 005 080");
        waveList.Add(round);

        round = new List<string>();//145
        round.Add("07 0 00350 060 000");
        round.Add("08 0 00120 030 000");
        round.Add("01 0 00035 030 000");
        round.Add("10 0 00200 030 030");
        round.Add("03 0 00045 030 030");
        waveList.Add(round);


        round = new List<string>();//146
        round.Add("03 0 00030 020 000");
        round.Add("08 0 00120 020 020");
        round.Add("07 0 00250 020 020");
        round.Add("03 0 00040 020 040");
        round.Add("01 0 00040 020 040");
        round.Add("01 0 00030 020 060");
        round.Add("10 0 00100 020 060");
        waveList.Add(round);

        round = new List<string>();//147
        round.Add("10 0 00400 030 000");
        round.Add("08 0 00120 030 000");
        round.Add("01 0 00035 030 000");
        round.Add("08 0 00105 030 030");
        round.Add("01 0 00045 010 050");
        waveList.Add(round);

        round = new List<string>();//148
        round.Add("10 0 00200 060 000");
        round.Add("01 0 00025 060 000");
        round.Add("08 0 00100 020 060");
        round.Add("03 0 00030 005 080");
        waveList.Add(round);

        round = new List<string>();//149
        round.Add("t 00 03 GHOSTS");
        round.Add("t 06 03 THEIR FAST AND HARD TO SEE");
        round.Add("t 12 03 THEY SPLIT AND THEY SHOOT");
        round.Add("t 12 03 HAVE FUN");
        round.Add("11 0 00350 040 000");
        waveList.Add(round);

        round = new List<string>();//150
        round.Add("11 0 00400 060 000");
        round.Add("01 0 00080 060 000");
        waveList.Add(round);

        round = new List<string>();//151
        round.Add("11 0 00400 060 000");
        round.Add("01 0 00080 060 000");
        waveList.Add(round);

        round = new List<string>();//152
        round.Add("01 0 00025 030 000");
        round.Add("08 0 00080 030 030");
        round.Add("11 0 00300 030 060");
        waveList.Add(round);


        /*

        round = new List<string>();
        round.Add("11 0 00200 020 000");
        round.Add("10 0 00050 020 000");
        round.Add("06 0 00100 020 000");
        waveList.Add(round);

        round = new List<string>();
        round.Add("08 0 00080 020 000");
        round.Add("06 0 00200 030 000");
        round.Add("01 0 00020 030 000");
        waveList.Add(round);

        round = new List<string>();
        round.Add("07 0 00300 005 000");
        round.Add("08 0 00030 010 000");
        round.Add("01 0 00020 010 000");
        waveList.Add(round);


        round = new List<string>();
        round.Add("11 0 00200 020 000");
        round.Add("07 0 00100 002 000");
        waveList.Add(round);


        round = new List<string>();
        round.Add("07 0 00300 005 000");
        round.Add("08 0 00030 010 000");
        round.Add("01 0 00020 010 000");
        waveList.Add(round);


        round = new List<string>();
        round.Add("07 0 00300 004 000");
        round.Add("06 0 00300 010 000");
        round.Add("08 0 00020 020 000");
        round.Add("01 0 00015 020 000");
        waveList.Add(round);

        round = new List<string>();
        round.Add("08 0 00020 040 000");
        round.Add("01 0 00020 040 000");
        waveList.Add(round);


        round = new List<string>();
        round.Add("08 0 00018 040 000");
        round.Add("01 0 00016 040 000");
        waveList.Add(round);

        round = new List<string>();
        round.Add("08 0 00018 040 000");
        round.Add("01 0 00014 040 000");
        waveList.Add(round);
        */




        round = new List<string>();//000
        round.Add("t 00 10 YOU HAVE BEAT SECOND DIMENSION");
        waveList.Add(round);


        PlayerPrefs.SetInt("enemies", 0);

        waveText = WaveTextGO.GetComponent<TextMeshProUGUI>();
        Color c = waveText.color;
        c.a = 0.0f;
        waveText.color = c;
        waveActiveText.text = "WAVE: " + (PlayerPrefs.GetInt("waveNumber", 0) + 1);
        refillHealth.SetActive(false);

        StartCoroutine(createSpawn());
    }
    




    IEnumerator createSpawn()
    {
        if(PlayerPrefs.GetInt("waveNumber", 0) == 0)
        {
           // yield return new WaitForSeconds(12);
        }
        foreach (var Sublist in waveList)
        {
            if (!(waveList.IndexOf(Sublist) < PlayerPrefs.GetInt("waveNumber", 0)))
            {
                StartCoroutine(refillHealthShow());
                yield return new WaitForSeconds(1);
                
               // Time.timeScale = 0;
                //AudioListener.volume = 0f;
               // Advertisement.Show("rewardedVideo");
               // Time.timeScale = 1;
               // AudioListener.volume = 1f;

                PlayerPrefs.SetInt("enemies", 0);

                foreach (string Code in Sublist)
                {
                    if(Code[0] == 116)
                    StartCoroutine(createTutorial(Code));
                    else
                    StartCoroutine(createAttack(Code));                    
                }

                yield return new WaitForSeconds(10);
                if(PlayerPrefs.GetInt("waveNumber", 0) == 1)
                {
                    yield return new WaitForSeconds(15);
                }
                while (PlayerPrefs.GetInt("enemies", 0)!=0)
                {
                    yield return new WaitForSeconds(2);
                }

                yield return new WaitForSeconds(2);


                PlayerPrefs.SetInt("waveNumber", PlayerPrefs.GetInt("waveNumber", 0) + 1);
                waveActiveText.text = "WAVE: " + (PlayerPrefs.GetInt("waveNumber", 0)+1);

            }
        }
    }
    IEnumerator createAttack(string Code)
    {
        int EnemyType = (Code[0] - 48) * 10 + (Code[1] - 48);
        int spawnLocation = Code[3]-48;
        int spawnSpeed = (Code[5]-48)*10000 + (Code[6]-48)*1000 + (Code[7]-48)*100 + (Code[8]-48)*10 + (Code[9]-48);
        int spawnDuration = (Code[11]-48)*100 + (Code[12]-48)*10 + (Code[13]-48);
        int spawnDelay = (Code[15] - 48) * 100 + (Code[16] - 48) * 10 + (Code[17] - 48);

        yield return new WaitForSeconds(spawnDelay);
        es.ExecuteSpawn(EnemyType,spawnLocation,spawnSpeed,spawnDuration);
    }
    IEnumerator createTutorial(string Code)
    {
        int delay = (Code[2] - 48) * 10 + (Code[3] - 48);
        int seconds = (Code[5] - 48) * 10 + (Code[6] - 48);

        string resultText = "";
        for(int i = 8; i<Code.Length; i++)
        {
            resultText += Convert.ToChar(Code[i]);
        }

        print(resultText);
        print(delay + "");
        print(seconds + "");
        yield return new WaitForSeconds(delay);
        print("wait complete");
        ts.tutorialText(resultText, seconds);

    }
    IEnumerator refillHealthShow()
    {
        if(PlayerPrefs.GetInt("waveNumber", 0) != 0)
        {
            refillHealth.SetActive(true);
            ss.refillHealthShow();
            yield return new WaitForSeconds(0.1f);
            PlayerPrefs.SetInt("waveHealth", PlayerPrefs.GetInt("playerHealth", 10));
            StartCoroutine(FadeWaveText());
            yield return new WaitForSeconds(4f);
            refillHealth.SetActive(false);
        }

    }
    IEnumerator FadeWaveText()
    {
        waveText.text = "WAVE " + (PlayerPrefs.GetInt("waveNumber", 0)+1);

        waveText = WaveTextGO.GetComponent<TextMeshProUGUI>();
        Color n = waveText.color;
        n.a = 0f;
        waveText.color = n;
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color c = waveText.color;
            c.a = f;
            waveText.color = c;
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(1.5f);
        for (float f = 1; f >= -0.05; f -= 0.05f)
        {
            Color c = waveText.color;
            c.a = f;
            waveText.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

}
