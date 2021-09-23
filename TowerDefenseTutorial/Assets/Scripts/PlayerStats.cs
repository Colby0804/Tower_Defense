using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public static int Lives;
    public int startLives = 20;
    public int playerMoney = 100;

    public static int Rounds;

    void Start()
    {
        Lives = startLives;

        Rounds = 0;

        Money = playerMoney;
    }
}
