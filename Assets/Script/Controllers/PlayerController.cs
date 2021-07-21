using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _jump;
    [SerializeField]
    private float _speed;
    
    void Start()
    {
        Managers.Input.KeyAction -= OnKeyBoard;
        Managers.Input.KeyAction += OnKeyBoard;
    }

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * _speed);
    }


    void OnKeyBoard() {



        if (Input.GetKey("escape"))
            SceneManager.LoadScene("Lobby");
    }
}
