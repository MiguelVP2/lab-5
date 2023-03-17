using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Bstate {START, PLAYERTURN, ENEMYTURN, WON, LOST}
public class Battles : MonoBehaviour
{
    public Bstate state;
    public GameObject player;
    public GameObject enemy;
    public Transform playerBattle;
    public Transform enemyBattle;
    
    // Start is called before the first frame update
    void Start()
    {
        state = Bstate.START;
        SetBattle();
    }

    void SetBattle()
    {
        GameObject playerGO = Instantiate(player, playerBattle);
        GameObject enemyGO = Instantiate(enemy, enemyBattle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
