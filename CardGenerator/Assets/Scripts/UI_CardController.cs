using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI_CardController : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI description;
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI effectDesctiption;
    [SerializeField] Animator anim;
    public void SetTitle(string newTitle)
    {
        title.text = newTitle;
    }
    public void SetDesctiption(string newDesctiption)
    {
        description.text = newDesctiption;
    }
    public void SetImage(Sprite newImage)
    {
        image.sprite = newImage;
    }
  
    public void SetEffectDescription(CardEffect effect)
    {
        effectDesctiption.text = "HP:" + effect.addHealPoint + "\nMana:" + effect.addMana + "\nSpeed:" + effect.addSpeed;
    }
    public void PlayUseAnimation()
    {
        anim.SetTrigger("play");
    }
}
