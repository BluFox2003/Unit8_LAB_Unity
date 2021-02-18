using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    public static void KillPlayer(Player player) {
        Destroy(player.gameObject);
        gm.RespawnPlayer();
    }
    public Transform playerPrefab;
    public Transform spawnPoint;

    public void RespawnPlayer(){
        Debug.Log("TODO: Add sound for respawning");
        Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void Start(){
        if (gm == null){
            gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();
        }
    }
    
}
