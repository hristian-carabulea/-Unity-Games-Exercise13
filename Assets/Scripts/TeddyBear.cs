using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear moving right
/// </summary>
public class TeddyBear : MonoBehaviour
{
	/// <summary>
    /// Start is called before the first frame update
    /// </summary>
	void Start()
    {
        // get the teddy bear moving
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(3, -3),
            ForceMode2D.Impulse);
    }
	
}