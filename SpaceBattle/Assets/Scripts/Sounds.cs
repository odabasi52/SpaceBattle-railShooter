using UnityEngine;
using UnityEngine.UI;

public class Sounds : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("volume"))
        PlayerPrefs.SetFloat("volume", 1);

        else
        Load();
    }

    public void SetVolume()
    {
       
        AudioListener.volume = volumeSlider.value;
        Save();

    }
     
    void Load()
    {
      volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }

    void Save()
    {
        PlayerPrefs.SetFloat("volume" , volumeSlider.value);
    }
      
}
