using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    //bool flipFlag =false;
    float speed = 0;
    float up = 0;//변수선언
    Vector2 startPos;
    Vector2 endPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스왼쪽버튼
        {
            this.startPos = Input.mousePosition; //처음 마우스 누를때 위치값
            //this.speed = 0.2f; //처음속도 this.speed대입
        }

        else if (Input.GetMouseButtonUp(0)) //마우스 눌렀다 땠을 때 위치값
        {
            
            this.endPos = Input.mousePosition;
            //Vector2 endPos = Input.mousePosition;
            float length = (this.endPos.x - this.startPos.x); //나중위치에서 처음위치를 뺀 좌표값을 length에 대입
            //if (length < 0) { flipFlag = true; }
            //else if (length>0)
                //{ flipFlag = true; }
            float lengthUp = (this.endPos.y - this.startPos.y);
            
            //this.GetComponent<SpriteRenderer>().flipX = flipFlag;
            //처음속도 this.speed대입
            this.speed = length;
            this.up = lengthUp; //y축
            this.GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed*Time.deltaTime, this.up * Time.deltaTime, 0); //x,y,z 이동 *deltaTime--> 다른사양에서 동일한 결과,방향
        this.speed *= 0.70f; //감속
        this.up *= 0.70f;
    }
}
