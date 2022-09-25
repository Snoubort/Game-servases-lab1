Основы работы с Unity
Отчет по лабораторной работе #1 выполнил(а):
- Кулаков Иван Александрович
- РИ300003
| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * |  |
| Задание 2 | * |  |
| Задание 3 | * |  |
## Цель работы
Освоить основы работы с Unity
## Задание 1
###В разделе «ход работы» пошагово выполнить каждый пункт с описанием и примера реализации задач по теме видео самостоятельной работы.
Ход работы:
- Создать новый проект из шаблона 3D – Core;
- Проверить, что настроена интеграция редактора Unity и Visual Studio Code (пункты 8-10 введения);
- Создать объект Plane;
- Создать объект Cube;
-	Создать объект Sphere;
-	Установить компонент Sphere Collider для объекта Sphere;
-	Настроить Sphere Collider в роли триггера;
-	Объект куб перекрасить в красный цвет;
-	Добавить кубу симуляцию физики, при это куб не должен проваливаться под Plane;
- Написать скрипт, который будет выводить в консоль сообщение о том, что объект Sphere столкнулся с объектом Cube;
'''C#

    public class AddCollider : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other) {
            Debug.Log("Произошло столкновение с " + other.gameObject.name);
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green); 
        }

        private void OnTriggerExit(Collider other) {
            Debug.Log("Завершили столкновение с " + other.gameObject.name);
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
    
'''
- При столкновении Cube должен менять свой цвет на зелёный, а при завершении столкновения обратно на красный.

## Задание 2
### Продемонстрируйте на сцене в Unity следующее:
- Что произойдёт с координатами объекта, если он перестанет быть дочерним?
Координаты объекта изменятся с локальных на мировые
- Создайте три различных примера работы компонента RigidBody?
Падение(гравитация), Существование как физической сущности(kinematic), Активация тригеров

## Задание 3
### Реализуйте на сцене генерацию n кубиков. Число n вводится пользователем после старта сцены.
Создаём public переменную типа int
Считываем значение переменной при обновлении
Если значение - верное количество объектов - спавник кубики
'''C#

    public class ReadLine : MonoBehaviour
    {
        public int n = -1;
        public GameObject PrefCub;
        public GameObject self;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(n >=0){
                for (int i = 0; i<n; i++){
                    Instantiate(PrefCub, self.transform.position, self.transform.rotation);
                }
                n = -1;
            }

        }
    }
    
'''



