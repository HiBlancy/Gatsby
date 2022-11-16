using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : MonoBehaviour
{
    public static float moveHorizontal = 1f;
    public static float speed = 1f;

    bool isGroundFloor = true;

    [SerializeField] LayerMask groundLayer;
    public float frontGroundRayDistance = 0.25f;
    public float floorCheckY = 0.52f;
    public float frontCheck = 0.51f;
    public float frontDistance = 0.001f;

    RaycastHit2D hit;

    void Update()
    {
        isGroundFloor = (Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - floorCheckY),
            new Vector2(moveHorizontal, 0), frontGroundRayDistance, groundLayer));
        if(!isGroundFloor)
            moveHorizontal *= -1;

        if (Physics2D.Raycast(transform.position, new Vector2(moveHorizontal, 0), frontCheck, groundLayer))
            moveHorizontal *= -1;    
    }
}