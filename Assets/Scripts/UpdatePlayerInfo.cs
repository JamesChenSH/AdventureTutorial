using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlayerInfo : MonoBehaviour
{
    public GameObject playerTimerObj;
    private float timerLeft = 120;
    private Text timerText;
    public GameObject playerInventoryObj;
    private int mushroomCount = 0;
    private Text mushroomText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = playerTimerObj.GetComponent<Text>();
        initializeTimer();
        mushroomText = playerInventoryObj.GetComponent<Text>();
        initializeMushroom();
    }

    public void initializeTimer(){
        timerLeft = 120;
        updateTimerText();
    }

    public void updateTimerText(){
        timerText.text = "Time Left: " + (int)timerLeft + "s";
    }

    public void initializeMushroom(){
        mushroomCount = 0;
        updateMushroomText();
    }

    public void updateMushroomText(){
            if(mushroomCount > 0 ){
                mushroomText.text += "Mushroom x" + mushroomCount;
            } else{
                mushroomText.text += "Empty";
            }

    }

    // Update is called once per frame
    void Update()
    {
        if(timerLeft > 0){
            timerLeft = timerLeft - Time.deltaTime;
            updateTimerText();
        }
    }
}
