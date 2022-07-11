using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {
        // 혹시라도 다른쪽에서 구독 신청을 하고 있다면 삭제하고 재구독 해라.
        Managers.input.KeyAction -= OnKeyboard;
        // 인풋 매니저의 키엑션이 발생하면 OnKeyboard 함수를 실행해라.
        Managers.input.KeyAction += OnKeyboard;
    }


    // Update 함수는 한 프레임당 호출한다
    // 60프엠임의 게임이라면 1/60초 마다 이동하게된다
    float _yAngle = 0.0f;
    void Update()
    {
       
    }

    void OnKeyboard(){

        float sp = Time.deltaTime * _speed;
        float rsp = Time.deltaTime * 100f;

        _yAngle += rsp;
        // 오일러앵글
        // 절대 회전값
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        // 특정 축을 기준으로 회전
        // +- delta
        //transform.Rotate(new Vector3(0.0f, rsp, 0.0f));
        
        //특정 방향으로 회전
        //Quaternion qt = new Quaternion();
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));


        // transform (w,a,s,d)         
        if(Input.GetKey(KeyCode.W)){
            //transform.position += new Vector3(0.0f, 0.0f, 1.0f) * sp;
            // transform.position : world 좌표
            // transform.TransformDirection (Local -> World)
            // transform.InverseTransformDirection (World -> Local)
            
            //transform.position += transform.TransformDirection(Vector3.forward * sp);
            
            // 위치 이동
            //transform.Translate(Vector3.forward * sp);
            
            // 방향 전환
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            
            // 부드러운 방향 전환
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            //transform.Translate(Vector3.forward * sp);
            transform.position += Vector3.forward * sp;
            
        }
        if(Input.GetKey(KeyCode.S)){
            //transform.Translate(Vector3.back * sp);
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
             transform.position += Vector3.back * sp;
        }
        if(Input.GetKey(KeyCode.A)){
            //transform.Translate(Vector3.left * sp);
            //transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
             transform.position += Vector3.left * sp;
        }
        if(Input.GetKey(KeyCode.D)){
            //transform.Translate(Vector3.right * sp);
            //transform.rotation = Quaternion.LookRotation(Vector3.right);  
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
             transform.position += Vector3.right * sp;
        }
        
    }
}
