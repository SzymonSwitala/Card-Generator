using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardController : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI description;
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI effectDesctiption;
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
    public void SetEffectDesctiption(string newEffectDesctiption)
    {
        effectDesctiption.text = newEffectDesctiption;
    }
}
