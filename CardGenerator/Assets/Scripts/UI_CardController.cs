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

    public void PlayUseAnimation()
    {
        anim.SetTrigger("play");
    }

    public void SetNewCard(string newTitle, string newDesctiption, Sprite newImage, CardEffect effect)
    {
        title.text = newTitle;
        description.text = newDesctiption;
        image.sprite = newImage;
        effectDesctiption.text = "HP:" + effect.addHealPoint + "\nMana:" + effect.addMana + "\nSpeed:" + effect.addSpeed;
    }
    
}

