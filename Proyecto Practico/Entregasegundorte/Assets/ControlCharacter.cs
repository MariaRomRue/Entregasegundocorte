using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {
    public GameObject characterPrincipal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        //transform.position += Vector3.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position += Vector3.forward * Time.deltaTime;
        }

        //Cuando presione la tecla DOWN el carro avanza hacia atras o en reversa
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position -= Vector3.forward * Time.deltaTime;
        }
        //Cuando presione la tecla RIGHT