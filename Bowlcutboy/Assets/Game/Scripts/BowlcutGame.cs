using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class BowlcutGame : MonoBehaviour {

    const int Health = 100;
    const int Damage = 50;

    public State startingState;
    public Text BoyIntroText;
    public Text RottlingerIntroText;
    public Text AttackInfo;
    public Text AttackOne;
    public Text DamageText;
    public Text Dodge;
    public Text HealthDoctor;
    public Text HealthBoy;

    private SceneLoader sceneLoader;
    private State actualState;

    private void IntroSetupUI()
    {
        BoyIntroText.enabled = true;
        RottlingerIntroText.enabled = false;


    }

    void SetupRottlingerUI()
    {
        BoyIntroText.enabled = false;
        RottlingerIntroText.enabled = true;
    }

    void Start()
    {
        sceneLoader = loadSceneObject.GetComponent<SceneLoader>();
        actualState = startingState;
        textIntroComponent.text = actualState.GetStateStory();
        BoyIntroText.text = actualState.GetStateStoryMenue();

        ResetValues();

        //statesUntilRescue = 30;
        wait = false;
        Debug.Log("Enter");

        SetupIntroUI();
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
