using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls
{
    private PlayerMovementC13 _playerMovement;

    public PlayerControls(PlayerMovementC13 playerMovement)
    {
        _playerMovement = playerMovement;
    }

    public void ArtificialUpdate()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        if(horizontal != 0 || vertical != 0)
        {
            _playerMovement.Direction(horizontal, vertical);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _playerMovement.Jump();
        }
    }
}
