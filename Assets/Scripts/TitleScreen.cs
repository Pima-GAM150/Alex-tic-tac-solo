using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{

    public Texture backgroundTexture;


    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * .30f, Screen.width * .5f, Screen.height * .1f), "Single Player"))
        {
            print("Single Player Game Start");
            Application.LoadLevel("first tic tac");
        }
        if (GUI.Button(new Rect(Screen.width * .375f, Screen.height * .60f, Screen.width * .25f, Screen.height * .1f), "Exit"))
        {
            print("Exit Game");
            Application.Quit();
        }
        //if (GUI.Button(new Rect(Screen.width * .35f, Screen.height * .45f, Screen.width * .30f, Screen.height * .1f), "PlayerVsPlayer"))
        //{
        //    print("PvP Game Start");
        //}
    }
}