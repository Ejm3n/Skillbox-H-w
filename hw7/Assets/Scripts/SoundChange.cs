using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundChange : MonoBehaviour
{
    private bool SoundOff = true;
    public AudioSource music;
    public AudioSource Battle;
    public AudioSource EatingCycle;
    public AudioSource HirePeasant;
    public AudioSource HireWarrior;
    public AudioSource HarvestCycle;
    public Sprite ImageSoundOn;
    public Sprite ImageSoundOff;
    public Image SoundChangerImage;
    public void OnVolumeChange()
    {
        if(!SoundOff)
        {
            music.mute = SoundOff;
            Battle.mute = SoundOff;
            EatingCycle.mute = SoundOff;
            HirePeasant.mute = SoundOff;
            HireWarrior.mute = SoundOff;
            HarvestCycle.mute = SoundOff;
            SoundOff = !SoundOff;
            SoundChangerImage.sprite = ImageSoundOn;
        }
        else
        {
            music.mute = SoundOff;
            Battle.mute = SoundOff;
            EatingCycle.mute = SoundOff;
            HirePeasant.mute = SoundOff;
            HireWarrior.mute = SoundOff;
            HarvestCycle.mute = SoundOff;
            SoundOff = !SoundOff;
            SoundChangerImage.sprite = ImageSoundOff;
        }
    }
}
