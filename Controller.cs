using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public int Speed;
    public int Hp = 100;
    Rigidbody rigidbody;
     void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }



    void Jump() {
        //점프
        if (rigidbody.velocity.y == 0) {
            rigidbody.AddForce(Vector3.up * 3000f);
        }
    }
    void Update() {
        //떨어지면 돌아오는 부분
        if (transform.position.y <= -10) {
            transform.position = new Vector3(0, 3, 0);
        }
        //스페이스 눌리면
        if (Input.GetKey(KeyCode.Space)) {
            Jump();
        }
        Run();
    }

    //이동 함수
    void Run() {
        if (Input.GetKey(KeyCode.LeftShift)) {
            Speed = 20;//달리기 구현
        } else {
            Speed = 10;
        }  var x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        transform.Translate(x, 0, z);
    }
}

