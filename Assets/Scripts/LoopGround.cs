using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 10f; // Added this variable

    private SpriteRenderer _spriteRenderer;
    private Vector2 _startSize; // Fixed casing to match

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    private void Update()
    {
        // Increase the width of the sprite over time
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);

        // Reset to original size once it exceeds the width threshold
        if (_spriteRenderer.size.x > _startSize.x + _width)
        {
            _spriteRenderer.size = _startSize;
        }
    }
}