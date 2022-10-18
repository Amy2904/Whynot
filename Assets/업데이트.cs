using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KYR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
    }

    void SetResolution()
    {
        int setWidth = 1920;
        int setHeight = 1080;

        Screen.SetResolution( Screen.width, (Screen.width * 16) / 9 , true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

     public void OnClickNewGame()
    {
        Debug.Log("새 게임");
    }

    public void OnClickLoad()
    {
        Debug.Log("로드");
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.QUIT();
#endif
    }

}

