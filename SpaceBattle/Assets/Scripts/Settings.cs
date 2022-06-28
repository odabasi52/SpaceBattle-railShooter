using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{   
    void Start() 
    {
      Cursor.visible = true;
    }
    
    public void SetQuality(int quality)
    {   
        QualitySettings.SetQualityLevel(quality);
        PlayerPrefs.SetInt("QualityX" , quality);
    }

    public void SetFullScreen(bool isFull)
    {   
      Screen.fullScreen = isFull;
    }
    
    public void SetRes()
    {
      string res = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

      switch(res)
      {
        case "0" :
        Screen.SetResolution(1920,1080,true);
        break;

        case "1" :
        Screen.SetResolution(1280,720,true);
        break;

        case "2" :
        Screen.SetResolution(1024,768,true);
        break;

        case "3" :
        Screen.SetResolution(800,600,true);
        break;
      }

    }

}
