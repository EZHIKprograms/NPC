using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    int health = 5;// Хп неписи
    int level = 1; // Уровень неписи
    float speed = 1.2f; // скорость неписи
    Vector3 newPosition; // положение объекта
    void Start()
    {
        health+=level; // прибавляет к количеству жизней неписи его уровень.
        print("Здоровье NPC:"+health);// вывод в консоль
        newPosition = transform.position; //позиция
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime; //Движение
        transform.position = newPosition; // изменение положения
    }
}
