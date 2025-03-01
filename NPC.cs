using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //хп npc
    public int health = 5;
    //level nps
    public int level = 1;
    public float speed = 1.2f;
    void Start()
    {
        //сложения хп плюс девел 
        health += level;
        //вывод хп
        print("жизней" + health);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
