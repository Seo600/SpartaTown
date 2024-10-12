using System;
using UnityEngine;

public class LookMousePoint : MonoBehaviour
{
    [SerializeField] private SpriteRenderer penguinRangerer;
    [SerializeField] private SpriteRenderer knightRangerer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += Look;
    }

    private void Look(Vector2 direction)
    {
        MousePoint(direction);
    }

    private void MousePoint(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(CharacterManager.characterNumber == 1)
        {
            penguinRangerer.flipX = Mathf.Abs(rotZ) > 90;
        }
        else
        {
            knightRangerer.flipX = Mathf.Abs(rotZ) > 90;
        }
        
    }
}
