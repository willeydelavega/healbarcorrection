using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text _textDisplayPlayer;
    [SerializeField] TMP_Text _textDisplayAlly;
    [SerializeField] Slider _healthSliderPlayer;
    [SerializeField] Slider _healthSliderAlly;
    public IntVariable PlayerHP;
    public IntVariable AllyHP;
    private float lastPlayerHP;
    private float lastAllyHP;

    private void Start()
    {
        _healthSliderPlayer.maxValue = PlayerHP.Value;
        _healthSliderAlly.maxValue = AllyHP.Value;
        SetAndDisplayHP("Player");
        SetAndDisplayHP("Ally");
        
    }
    void Update()
    {
        //les hp ont changé à cette frame    
        if (PlayerHP.Value != lastPlayerHP)
        {
            SetAndDisplayHP("Player");
        }
        if (AllyHP.Value != lastAllyHP)
        {
            SetAndDisplayHP("Ally");
        }
    }
    void SetAndDisplayHP(string name)
    {
        if (name == "Player")
        {
            _textDisplayPlayer.text = "Player HP = " + PlayerHP.Value;
            _healthSliderPlayer.value = PlayerHP.Value;
            lastPlayerHP = PlayerHP.Value;
        }
        else if (name == "Ally")
        {
            _textDisplayAlly.text = "Ally HP = " + AllyHP.Value;
            _healthSliderAlly.value = AllyHP.Value;
            lastAllyHP = AllyHP.Value;
        }
    }
    // public void SetMaxHealth(int maxHealth)
    // {
    //     _healthSlider.maxValue = maxHealth;
    //     _healthSlider.value = maxHealth;
    // }
    // public void SetHealth(int health)
    // {
    //     _healthSlider.value = health;
    // }
}
