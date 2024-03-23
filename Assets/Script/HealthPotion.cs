using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int healthAmount = 30;
   [SerializeField] private PlayerHealth _playerHeal;
    void OnTriggerEnter(Collider other)
    {
        //пробуем взять у объекта с которым мы столкнулись компонент системы здоровья
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        //если такой действительно существует
        if (_playerHeal != null)
        {
            _playerHeal = GetComponent<PlayerHealth>();
            //добавляем игроку здоровье
            ////////////////////////////////////_playerHeal.AddHealth(-10);/////////////////////
            //уничтожаем объект лечилку
            Destroy(gameObject);
        }
    }
}
