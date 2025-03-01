using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //�� npc
    public int health = 5;
    //level nps
    public int level = 1;
    public float speed = 1.2f;
    void Start()
    {
        //�������� �� ���� ����� 
        health += level;
        //����� ��
        print("������" + health);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
