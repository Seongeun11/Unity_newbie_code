using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    //bool flipFlag =false;
    float speed = 0;
    float up = 0;//��������
    Vector2 startPos;
    Vector2 endPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���콺���ʹ�ư
        {
            this.startPos = Input.mousePosition; //ó�� ���콺 ������ ��ġ��
            //this.speed = 0.2f; //ó���ӵ� this.speed����
        }

        else if (Input.GetMouseButtonUp(0)) //���콺 ������ ���� �� ��ġ��
        {
            
            this.endPos = Input.mousePosition;
            //Vector2 endPos = Input.mousePosition;
            float length = (this.endPos.x - this.startPos.x); //������ġ���� ó����ġ�� �� ��ǥ���� length�� ����
            //if (length < 0) { flipFlag = true; }
            //else if (length>0)
                //{ flipFlag = true; }
            float lengthUp = (this.endPos.y - this.startPos.y);
            
            //this.GetComponent<SpriteRenderer>().flipX = flipFlag;
            //ó���ӵ� this.speed����
            this.speed = length;
            this.up = lengthUp; //y��
            this.GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed*Time.deltaTime, this.up * Time.deltaTime, 0); //x,y,z �̵� *deltaTime--> �ٸ���翡�� ������ ���,����
        this.speed *= 0.70f; //����
        this.up *= 0.70f;
    }
}
