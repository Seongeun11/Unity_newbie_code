using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() //매 프래임마다 한번만 실행
    {
        this.transform.Translate(10.0f, 0, 0); //이 스크립트가 속해 있는 게임오브젝트의 트랜스폼컨퍼넌트를 이동시킨다
    }

    // Update is called once per frame
    void Update() //매 프레임마다 계속적으로 갱신
    {
        
    }
}
