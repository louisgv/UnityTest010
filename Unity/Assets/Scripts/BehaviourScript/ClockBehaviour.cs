using UnityEngine;
using System.Collections;
using System;
public class ClockBehaviour : MonoBehaviour {
	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	public bool analog;
	public Transform clockHour, clockMinute, clockSecond;
	private const float
		hourDegree = 360f/12f,
		minuteDegree = 360f/60f,
		secondDegree = 360f/60f;
	void Update(){
		//Debug.Log(DateTime.Now.TimeOfDay.TotalHours); // It used the Time of Day
		//Debug.Log(DateTime.Now.TimeOfDay.TotalMinutes); // All elements are related to Day!
		Debug.Log(DateTime.Now.TimeOfDay.TotalSeconds); // Seconds... I wonder?

		if (analog){
			TimeSpan timeSpan = DateTime.Now.TimeOfDay;
			clockHour.localRotation= Quaternion.Euler(0f, 0f, (float)timeSpan.TotalHours * -hourDegree);
			clockMinute.localRotation = Quaternion.Euler (0f, 0f, (float)timeSpan.TotalMinutes * - minuteDegree);
			clockSecond.localRotation = Quaternion.Euler( 0f, 0f, (float)timeSpan.TotalSeconds * - secondDegree);
		}
		else {
			DateTime time = DateTime.Now;

			clockHour.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hourDegree);
			clockMinute.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minuteDegree);
			clockSecond.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondDegree);
		}
	}
}
