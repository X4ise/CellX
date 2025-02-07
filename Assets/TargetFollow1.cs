using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow1 : MonoBehaviour
{
    // Ссылка на объект EmptyTarget
    public Transform EmptyTarget;
    // Ссылка на объект MainCamera
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        // Дополнительная логика инициализации может быть добавлена здесь
    }

    // Update is called once per frame
    void Update()
    {
        if (EmptyTarget != null)
        {
            // Копируем позицию EmptyTarget только по осям X и Y
            transform.position = new Vector3(EmptyTarget.position.x, EmptyTarget.position.y, transform.position.z);

            // Изменяем размер камеры в зависимости от положения EmptyTarget по оси Z
            float distance = EmptyTarget.position.z;

            // Задаем размер камеры (например, ширина) на основе расстояния
            if (MainCamera.orthographic)
            {
                MainCamera.orthographicSize = Mathf.Max(1, distance);
            }
        }
        else
        {
            // Если EmptyTarget удален или не установлен, можно добавить логику обработки этого случая
            Debug.Log("EmptyTarget не установлен или был удален.");
        }
    }
}