using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Main2 : MonoBehaviour
{
	public List<List<int>> genome;
    private static List<int> id = new List<int>();
    public static int SIZE = 100;
	public static float[,] FOOD = new float[SIZE, SIZE];
	public static float[,] ORGANICS = new float[SIZE, SIZE];
	private System.Random random = new System.Random(); // Создаем экземпляр Random

	static Main2()
	{
		for (int i = 0 ; i < SIZE ; i++)
		{
			for (int j = 0 ; j < SIZE ; j++)
			{
				FOOD[i, j] = 100f;
				ORGANICS[i, j] = 25f;
			}
		}
	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			GameObject c = (GameObject) UnityEngine.Object.Instantiate(Resources.Load("Cell2", typeof(GameObject)), new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Cell2 cell2 = c.GetComponent<Cell2>();
            cell2.UID = GenerateRandomUID(); // Случайный UID новой клетки
            cell2.type = 0;
			cell2.hp = 40f;
            // начальный геном
            cell2.genome = new List<List<int>>();
            cell2.genome.Add(new List<int>() { 2, 1, 0, 2, 5, 0, 6, 6, 6, 6, 1, 3, 0, 7, 7, 7, 7, 3, 0, 0 });
            cell2.genome.Add(new List<int>() { 7 });
            cell2.genome.Add(new List<int>() { 7 });
            cell2.genome.Add(new List<int>() { 6 });
            cell2.genome.Add(new List<int>() { 0 });
            cell2.genome.Add(new List<int>() { 0 });
            cell2.genome.Add(new List<int>() { 0 });
        }
    }
	private static List<int> GenerateRandomUID()
	{
        for (int i = 0 ; i < 7 ; i++)
        {
            id[i] = Random.Range(0, 10); // Генерируем случайное число от 0 до 9 и преобразуем его в строку
        }
        return id;
	}
}