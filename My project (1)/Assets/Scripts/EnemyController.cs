using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour
{
    [SerializeField] Slider hpBar;
    [SerializeField] Slider manaBar;
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] TextMeshProUGUI manaText;
    [SerializeField] TextMeshProUGUI speedText;

    [SerializeField] int hpPoint = 100;
    private int maxHpPoint;
    [SerializeField] int manaPoint = 100;
    private int maxManaPoint;
    [SerializeField] int speed=20;
    private void Start()
    {
        maxHpPoint = hpPoint;
        maxManaPoint = manaPoint;
        hpBar.maxValue = maxHpPoint;
        manaBar.maxValue = maxManaPoint;

        UpdateStats();
    }
    public void addHp(int hp)
    {
        hpPoint += hp;
    }
    public void addMana(int mana)
    {
        hpPoint += mana;
    }
    public void addSpeed(int speed)
    {
        speed += this.speed;
    }

    private void UpdateStats()
    {
        hpBar.value = hpPoint;
        manaBar.value = manaPoint;
        hpText.text = hpPoint + "/" + maxHpPoint;
        manaText.text = manaPoint + "/" + maxManaPoint;
        speedText.text = "Speed: " + speed;
    }
}
