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
### В разделе «ход работы» пошагово выполнить каждый пункт с описанием и примера реализации задач по теме видео самостоятельной работы.
Ход работы:
- Создать новый проект из шаблона 3D – Core;
- Проверить, что настроена интеграция редактора Unity и Visual Studio Code (пункты 8-10 введения);
![Скрин интеграция](https://github.com/Snoubort/Game-servases-lab1/blob/main/%D0%9F%D0%BE%D0%B4%D0%B3%D0%BE%D1%82%D0%BE%D0%B2%D0%BA%D0%B0.PNG?raw=true "Интеграция")
- Создать объект Plane;
![Скрин plane](https://github.com/Snoubort/Game-servases-lab1/blob/main/plane.PNG?raw=true "plane")
- Создать объект Cube;
![Скрин cube](https://github.com/Snoubort/Game-servases-lab1/blob/main/cube.PNG?raw=true "cube")
- Создать объект Sphere;
![Скрин sphere](https://github.com/Snoubort/Game-servases-lab1/blob/main/Sphere.PNG?raw=true "sphere")
- Установить компонент Sphere Collider для объекта Sphere;
- Настроить Sphere Collider в роли триггера;
![Скрин Sphere collider](https://github.com/Snoubort/Game-servases-lab1/blob/main/Sphere%20collider.PNG?raw=true "Sphere collider")
- Объект куб перекрасить в красный цвет;
![Скрин Red cube](https://github.com/Snoubort/Game-servases-lab1/blob/main/Red%20cube.PNG?raw=true "Red cube")
- Добавить кубу симуляцию физики, при это куб не должен проваливаться под Plane;
![Скрин Red cube phisics](https://github.com/Snoubort/Game-servases-lab1/blob/main/Red%20cube%20phisics.PNG?raw=true "Red cube phisics")
- Написать скрипт, который будет выводить в консоль сообщение о том, что объект Sphere столкнулся с объектом Cube;

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
        
- При столкновении Cube должен менять свой цвет на зелёный, а при завершении столкновения обратно на красный.
![Скрин Cube + sphere](https://github.com/Snoubort/Game-servases-lab1/blob/main/Cube%20%2B%20sphere.PNG?raw=true "Cube + sphere")
![Скрин Cube+sphere 2](https://github.com/Snoubort/Game-servases-lab1/blob/main/Cube%2Bsphere%202.PNG?raw=true "Cube+sphere 2")

## Задание 2
### Продемонстрируйте на сцене в Unity следующее:
- Что произойдёт с координатами объекта, если он перестанет быть дочерним?
Координаты объекта изменятся с локальных на мировые
![Скрин cube dom](https://github.com/Snoubort/Game-servases-lab1/blob/main/cube%20dom.PNG?raw=true "cube dom")
![Скрин Cube nod dom](https://github.com/Snoubort/Game-servases-lab1/blob/main/Cube%20nod%20dom.PNG?raw=true "Cube nod dom")
- Создайте три различных примера работы компонента RigidBody?
Падение(гравитация), Существование как физической сущности(kinematic), Активация тригеров
![Скрин Gravity, trigger detection, kinematic](https://github.com/Snoubort/Game-servases-lab1/blob/main/Gravity%2C%20trigger%20detection%2C%20kinematic.PNG?raw=true "Gravity, trigger detection, kinematic")
![Скрин Gravity, trigger, kinematic 2](https://github.com/Snoubort/Game-servases-lab1/blob/main/Gravity%2C%20trigger%2C%20kinematic%202.PNG?raw=true "Gravity, trigger, kinematic 2")
![Скрин Not detected](https://github.com/Snoubort/Game-servases-lab1/blob/main/Not%20detected.PNG?raw=true "Not detected")

## Задание 3
### Реализуйте на сцене генерацию n кубиков. Число n вводится пользователем после старта сцены.
Создаём public переменную типа int
Считываем значение переменной при обновлении
Если значение - верное количество объектов - спавник кубики
![Скрин Start spawn](https://github.com/Snoubort/Game-servases-lab1/blob/main/Start%20spawn.PNG?raw=true "Start spawn")
![Скрин End Spawn](https://github.com/Snoubort/Game-servases-lab1/blob/main/End%20Spawn.PNG?raw=true "End Spawn")

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
    
