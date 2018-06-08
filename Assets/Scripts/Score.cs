using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour {

    IEnumerator A(float time) {
        yield return new WaitForSeconds(time);
    }
        void OnTriggerEnter(Collider other) {
            StartCoroutine(A(4f));
            SceneManager.LoadScene("Main");
        }
}