using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CellStats : MonoBehaviour
{
    static void Listok()
	{
        Cell2 cell2 = new Cell2();
        List<int> uid = cell2.UID;
        List<int> uniqueID = uid.Distinct().ToList();
    }

    [SerializeField] private Text text;
	void Start()
	{
		
	}
	void Update()
	{
    }
	 void StringConv()
	 {

	 }
}