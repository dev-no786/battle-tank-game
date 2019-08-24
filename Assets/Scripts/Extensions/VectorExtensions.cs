
using UnityEngine;
public static class VectorExtensions 
{
	public static Vector3 SetX(this Vector3 vector, float newX)
	{
		return new Vector3(newX , 0 , 0); 
	}
	
}
