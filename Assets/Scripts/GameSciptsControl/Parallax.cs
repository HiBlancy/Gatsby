using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Transform bg0;
    [SerializeField] Transform bg1;
    [SerializeField] Transform bg2;

    float factor0 = 1f;
    float factor1 = 1 / 2f;
    float factor2 = 1 / 4f;

    float displacement;
    float inicialCmPosicionFrame;
    float nextCamaraPosicionFrame;

    void Update()
    {
        inicialCmPosicionFrame = transform.position.x;
        transform.position = new Vector3(PlayerMovement.obj.transform.position.x, transform.position.y, transform.position.z);
    }
     void LateUpdate()
    {
        nextCamaraPosicionFrame = transform.position.x;

        bg0.position = new Vector3(bg0.position.x + (nextCamaraPosicionFrame - inicialCmPosicionFrame) * factor0, bg0.position.y, bg0.position.z);
        bg1.position = new Vector3(bg1.position.x + (nextCamaraPosicionFrame - inicialCmPosicionFrame) * factor1, bg1.position.y, bg1.position.z);
        bg2.position = new Vector3(bg2.position.x + (nextCamaraPosicionFrame - inicialCmPosicionFrame) * factor2, bg2.position.y, bg2.position.z);
    }
}
