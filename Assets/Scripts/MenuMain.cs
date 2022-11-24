using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;
public class MenuMain : MonoBehaviour
{
    public  string playerName;
    public TMP_InputField inputField;
    public TMP_Text HighScore1;
    public TMP_Text HighName1;

    private void Awake()
    {
        WinnerList.Instance.LoadWinnerData();
        HighScore1.text =  WinnerList.Instance.bestScore+"" ;
        HighName1.text =  WinnerList.Instance.bestPlayer ;
        
    }
    public void start_btn()
    {
        WinnerList.Instance.playerName = inputField.text;
        SceneManager.LoadScene(1);
    }


    public void SaveName()
    {
        playerName = inputField.text;
        WinnerList.Instance.playerName = playerName;
    }

    private void Update()
    {
        playerName = inputField.text;
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
