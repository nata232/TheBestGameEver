using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   
    public float value = 100;
    public RectTransform valueRectTransform;
    private float _maxValue;


    public Slider Healthbar;
    public GameObject gameplayUI;
    public GameObject gameOverScreen;

    float _currentValue;

    void Start()
    {
        _maxValue = value;
        DrawHealthBar();

       // _currentValue = _maxValue;
        //UpdateHealthbar();
    }

    public void DealDamage(float damage)
    {
        value -= damage / 10;
        if (value <= 0)
        {
            PlayerIsDead();
        }

        DrawHealthBar();


    }   
       
    public void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }

    /*
    public void TakeDamage(float damage)
    {
        _currentValue -= damage;
        if (_currentValue <= 0)
        {
            _currentValue = 0;
            PlayerIsDead();
        }
        UpdateHealthbar();
    }

    public void AddHealth(float amount)
    {
        //Прибавить к текущему здоровью значение amount
        _currentValue += amount;
        //Если текущее здоровье больше, чем максимальное значение
        if (_currentValue > _maxValue)
        {
            //Текущее здоровье = максимальное значение
            _currentValue = _maxValue;
            
        }
        //Обновить полоску здоровья
        UpdateHealthbar();
    }

    void UpdateHealthbar()
    {
        Healthbar.value = _currentValue / _maxValue;
    }*/
    
    void PlayerIsDead()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<FireballCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }
}
