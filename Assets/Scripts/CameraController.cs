using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject character;

    public void StartGame()
    {
        character.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
