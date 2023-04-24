using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController
{
    private PlayerMovementC13 _playerMovement;

    public CollisionController(PlayerMovementC13 playerMovement)
    {
        _playerMovement = playerMovement;
    }

    public void ArtificialOnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 6)
        {
            _playerMovement.Ground = true;
        }

        if(collision.gameObject.layer == 7)
        {
            GameManager.Instance.Contador.Coins += 1;
            Debug.Log(GameManager.Instance.Contador.Coins);
        }

    }
}
