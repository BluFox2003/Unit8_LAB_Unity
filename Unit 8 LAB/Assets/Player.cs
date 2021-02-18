using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public class PlayerStats{
        public int Health = 10;
    }
    
    public PlayerStats playerStats = new PlayerStats();
    
    public void DamagePlayer(int damage){
        playerStats.Health -= damage;
        if (playerStats.Health <= 0) {
            Debug.Log("KILL PLAYER");
        }
    }

}

