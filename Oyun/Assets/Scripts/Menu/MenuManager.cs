using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class MenuManager : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Credits()
    {
        System.Diagnostics.Process.Start("notepad.exe", Application.dataPath+"/yapanlar.txt");
        Application.Quit();
    }
    public void Exit()
    {
        Application.Quit();
    }
}
