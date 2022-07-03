using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_selection : MonoBehaviour
{
  
   public GameObject[] characters;
   public int selected_character=0;
   
   public void NextCharacter(){
    characters[selected_character].SetActive(false);
    selected_character=(selected_character+1)%characters.Length;
    characters[selected_character].SetActive(true);
       }

    public void PrevCharacter(){
    characters[selected_character].SetActive(false);
    selected_character--;
    if (selected_character < 0)
    {
        selected_character += characters.Length;
    }

    characters[selected_character].SetActive(true);
       }
  public void Start_game(){
    PlayerPrefs.SetInt("selectedcharacter",selected_character);
    SceneManager.LoadScene("main",LoadSceneMode.Single);
  }
}
