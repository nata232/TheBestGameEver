using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   
   public float value = 100;

    public void DealDamage(float damage)
    {
        value -= damage / 10;
        if (value <= 0)
        {
            Destroy(gameObject);
        }

    }

    public float MaxValue = 100;
    public Slider Healthbar;

    public GameObject PlayerUI;
    public GameObject GameOverUI;

    float _currentValue;

    void Start()
    {
        _currentValue = MaxValue;
        UpdateHealthbar();
    }

    public void TakeDamage(float damage)
    {
        _currentValue -= damage;
        if (_currentValue <= 0)
        {
            _currentValue = 0;
            GameOver();
        }
        UpdateHealthbar();
    }

    public void AddHealth(float amount)
    {
        //Прибавить к текущему здоровью значение amount
        _currentValue += amount;
        //Если текущее здоровье больше, чем максимальное значение
        if (_currentValue > MaxValue)
        {
            //Текущее здоровье = максимальное значение
            _currentValue = MaxValue;
            
        }
        //Обновить полоску здоровья
        UpdateHealthbar();
    }

    void UpdateHealthbar()
    {
        Healthbar.value = _currentValue / MaxValue;
    }
    
    void GameOver()
    {
        PlayerUI.SetActive(false);
        GameOverUI.SetActive(true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }
}
