using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap : MonoBehaviour
{
    public static PlayerSwap Instance;
    void Start()
    {
        Instance = this;
    }

    public static playerControler selectedPlayer {  get; private set; }
    public static void pickSelectedPlayer(playerControler playercontroler)
    {
        if (selectedPlayer != null)
        {
            selectedPlayer.Selected(false);
        }
        selectedPlayer = playercontroler;
        selectedPlayer.Selected(true);
    }

    
}
