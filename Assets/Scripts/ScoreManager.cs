using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int playerScore = 0;
    public UpdatePlayerInfo updatePlayerInfo;

    // Start is called before the first frame update
    void Start()
    {
        updatePlayerInfo = GameObject.FindObjectOfType<UpdatePlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        playerScore += 1;
        updatePlayerInfo.UpdateScoreText(playerScore);
    }
}
