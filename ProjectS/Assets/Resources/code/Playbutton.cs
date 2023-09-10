using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
   public void play()
    {
        MainMenu menu = new MainMenu();
        menu.PlayGame();
        Debug.Log(SceneManager.GetActiveScene().name);
    }

}


