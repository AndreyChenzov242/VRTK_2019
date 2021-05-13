using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSlider : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _startPoint = 4.9f;
    [SerializeField] private float _endPoint = -5f;

    private bool _isLoweringWall;
    private Transform _transformWall;

    private void Start()
    {
        _transformWall = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        if(_isLoweringWall & _transformWall.position.y >= _endPoint)
        {
            WallMove(Vector3.down);
        }

        if(!_isLoweringWall & _transformWall.position.y < _startPoint)
        {
            WallMove(Vector3.up);
        }
    }

    void WallMove(Vector3 vector)
    {
        transform.Translate(vector * (_speed * Time.deltaTime));
    }

    public void StartLowerWall()
    {
        _isLoweringWall = true;
    }

    public void StartLiftWall()
    {
        _isLoweringWall = false;
    }
}
