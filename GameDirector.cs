using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    float lengthDis;
    float lengthDisY;
    GameObject player; //플레이어 오브젝트
    GameObject fruit; // 목표지점의 오브젝트
    GameObject distance; //목표지점까지 거리를 표시할 UI오브젝트
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

        //this.distance.GetComponent<Text>().text = "목표지점" + ":" + lengthDis.ToString("F2")+ "m";
        //ToString("D숫자") 정수형, 숫자는 자리수
        //this.distance.GetComponent<Text>().text = "목표지점" + ":" + Distance.ToString("F2") + "m";
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
        this.distance.GetComponent<Text>().text = "목표지점" + ":" + Distance.ToString("F2") + "m";
        return Distance;
    }
}
