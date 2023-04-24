using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerC13 : MonoBehaviour
{
    private PlayerControls _playerControls;
    private PlayerMovementC13 _playerMovement;
    private CollisionController _collisionController;
    [SerializeField] float _maxLife = 100;
    [SerializeField] float _currentLife = 100;

    string name = "Unity";

    private Rigidbody _rigidbody;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    [SerializeField] UIManager _uiManager;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _playerMovement = new PlayerMovementC13(transform, _speed, _rigidbody, _jumpForce, this);
        _playerControls = new PlayerControls(_playerMovement);
        _collisionController = new CollisionController(_playerMovement);
    }

    private void Start()
    {
        _uiManager.SetLifeText(_currentLife.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        _playerControls.ArtificialUpdate();
    }  

    private void OnCollisionEnter(Collision collision)
    {
        _collisionController.ArtificialOnCollisionEnter(collision);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == 8)
        {
            _currentLife -= 10;
            _uiManager.SetLifeBar(_currentLife / _maxLife);
            _uiManager.SetLifeText(_currentLife.ToString());
            //GameManager.Instance.UIController.ChangeValue(EnumUI.Life, _currentLife / _maxLife);
        }
    }

    public float Speed { get { return _speed;} set { _speed = value; } }
    public float JumpForce {  get { return _jumpForce; } }
}
