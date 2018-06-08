using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public bool Jumpping = false;
    public int Speed;
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

        //점프시 달리기 미적용 시키기 위한 코드
        if (rigidbody.velocity.y > 0) {
            Jumpping = true;
        } else {
            Jumpping = false;
        }


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
        if (!Jumpping) {
            if (Input.GetKey(KeyCode.LeftShift)) {
                Speed = 15;//달리기 구현
            } else {
                Speed = 10;
            }
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        transform.Translate(x, 0, z);
    }
}

