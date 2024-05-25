using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private bool isMuted;
    [SerializeField] Image on;
    [SerializeField] Image off;

    // Start is called before the first frame update
    void Start()
    {
        // isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        //  AudioListener.pause = isMuted;
        if(!PlayerPrefs.HasKey("isMuted"))
        {
            PlayerPrefs.SetInt("isMuted",0);
            Load();
        }
        else
        {
            Load();
        }
        
        UpdateButtonIcon();
        AudioListener.pause=isMuted;
    }

    private void UpdateButtonIcon()
    {
        if(isMuted == false)
        {
            on.enabled=true;
            off.enabled=false;
        }
        else
        {
            on.enabled=false;
            off.enabled=true;
        }
        Save();

    }
    // public void MutePressed()
    // {
    //     isMuted = !isMuted;
    //     AudioListener.pause = isMuted;
    //     PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
    // }

    public void OnButtonPress()
    {
        if(isMuted == false)
        {
            isMuted = true;
            AudioListener.pause=true;
        }
        else
        {
            isMuted = false;
            AudioListener.pause=false;
        }
        Save();
        UpdateButtonIcon();
    }
    private void Load(){
        isMuted=PlayerPrefs.GetInt("isMuted")==1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1:0);
    }
}
