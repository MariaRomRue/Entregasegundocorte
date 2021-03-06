using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour { 

    public GameObject characterPrincipal;
    public float velocidad = 20f;
    public GameObject bala;
    // Start is called before the first frame update
    void Start(){
        
    }
    // Update is called once per frame
    void Update() {
        //transform.position += Vector3.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        //Cuando presione La tecla DOWN el carro avanza hacia atras o en reversa
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position -= Vector3.forward * Time.deltaTime;
        }
        //Cuando presione La tecla RIGHT
        if (Input.GetKey(KeyCode.RightArrow)) {
            //transform.position += Vector3.right * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        //Cuando presione La tecla LEFT
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //transform.position -= Vector3.right * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        //Cuando presione La tecla space hago un disparo
        if (Input.GetKey(KeyCode.Space)){
            Instantiate (bala, transform.position, transform.rotation);

        }
     
    }

}