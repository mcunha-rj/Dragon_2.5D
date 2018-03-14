using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBehavirour : MonoBehaviour {

	[Header("Settings UI")]
	public Slider m_slider;
	public Text m_txtTime;
	public Text m_txtPoint;

	[Space(10)] [Header("Settings Plataform")]
	public float m_speed;

	int m_time, m_timeSlide, m_point, m_indexLetter;

	string[] m_letter = {
	"A","B","C","D","E",
	"F","G","H","I","J",
	"K","L","M","N","O",
	"P","Q","R","S","T",
	"U","V","X","Y","Z"};

	void OnEnable() {
		StartCoroutine(CounterTime());
	}

	void OnDisable() {
		StopAllCoroutines();
	}

	IEnumerator CounterTime(){
		m_time++;
		m_timeSlide++;
		m_point++;

		m_txtTime.text = string.Format("TIME    " + "{0:000}",m_time);
		m_slider.value = m_timeSlide / 6;
		
		if(m_time == 120)
			m_time = 0;

		if(m_point == 24){
			m_point = 0;
			m_txtPoint.text = "POINT      " + m_letter[m_indexLetter];
			m_indexLetter++;
		}
		yield return new WaitForSeconds(1);
		StartCoroutine(CounterTime());
	}
}
