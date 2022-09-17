using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePlayerInfo : MonoBehaviour
{
    public GameObject playerScoreObj;
    private TextMesh playerScoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerScoreText = playerScoreObj.GetComponent<TextMesh>();
        playerScoreText.text = "Score: 0";
    }

    public void UpdateScoreText(int score)
    {
        playerScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
