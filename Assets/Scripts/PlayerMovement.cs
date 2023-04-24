using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _gold;
    [SerializeField] float _life;
    [SerializeField] private float _speed;
    [SerializeField] Shop _actualShop;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");


        //var horizontal = Input.GetAxis("Horizontal");
        //var vertical = Input.GetAxis("Vertical");



        //Debug.Log(Input.GetAxisRaw("Vertical"));
        //Debug.Log(Input.GetAxisRaw("Horizontal"));

        if (horizontal != 0 || vertical != 0)
        {
            transform.position += new Vector3(horizontal, 0, vertical) * Time.deltaTime * _speed;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(_actualShop != null)
            {
                //_actualShop.Compra(ref _gold, _life);
                _actualShop.Compra("Cuchillo", "Revolver", "Espada");
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        var shop = other.GetComponent<Shop>();

        if(shop != null)
        {
            //shop.Compra(_gold);
            _actualShop = shop;
        }
    }
}
