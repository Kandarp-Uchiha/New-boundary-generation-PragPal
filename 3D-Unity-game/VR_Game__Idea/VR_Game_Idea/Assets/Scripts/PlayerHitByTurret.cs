using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitByTurret : MonoBehaviour
{


    public void TakeDamage(float amount)
    {
        PlayerManager.health -= amount;
        if(PlayerManager.health <= 0f)
        {
            PlayerDies();
        }
    }

    void PlayerDies()
    {
        // Destroy(gameObject.transform.GetChild(1).gameObject); // can cause problems so not required, just do GAME OVER
        PlayerManager.gameOver = true;
        FindObjectOfType<AudioManager>().PlaySound("GameOver");
    }
    
}
