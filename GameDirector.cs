using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    float lengthDis;
    float lengthDisY;
    GameObject player; //�÷��̾� ������Ʈ
    GameObject fruit; // ��ǥ������ ������Ʈ
    GameObject distance; //��ǥ�������� �Ÿ��� ǥ���� UI������Ʈ
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("duck");
        this.fruit = GameObject.Find("fruit");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        
        lengthDis = this.fruit.transform.position.x - this.player.transform.position.x;
        lengthDisY = this.fruit.transform.position.y -this.player.transform.position.y;
        float DistanceSquared = lengthDis * lengthDis + lengthDisY * lengthDisY;
        float Distance = Mathf.Sqrt(DistanceSquared);

        //this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + lengthDis.ToString("F2")+ "m";
        //ToString("D����") ������, ���ڴ� �ڸ���
        //this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + Distance.ToString("F2") + "m";
        GetDistance(lengthDis, lengthDisY);
        if (Distance<=1.5)
        {
            this.distance.GetComponent<Text>().text = "Game over" ;
        }
    }
    float GetDistance(float x, float y)
    {
        
        float DistanceSquared = x * x + y * y;
        float Distance = Mathf.Sqrt(DistanceSquared);
        this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + Distance.ToString("F2") + "m";
        return Distance;
    }
}
