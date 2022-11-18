# Робота зі списками

## Вступ

Для роботи зі списками використовувались класси [***ArrayList***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-7.0) та [***LinkedList&lt;T&gt;***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-7.0).

Був створенный класс [***Collection***](/blob/main/comparison%20ArrayList%20and%20LinkedList/Collection.cs) в якому знаходяться списки описані вище, та описані методи для перевірки часу: 
1. Доступу до елементу Random Access (доступ за індексом)
2. Доступу до елементу Sequential Access (доступ за ітератором)
2. Вставки елементу на початок списку
3. Вставки елементу в кінець списку
4. Вставки елементу в середину списку

## Дії для тестування

1. Добавимо до обоїх списків по 100,000 та зафіксуємо час операціі.
2. Перевіремо час доступу до елементів Random Access та Sequential Access.
3. Додамо елементи до списків на початок, середину та кінець списку та зафіксуємо час.

## Тестові випадки

Бло проведено тестування часу виконання операцій для списків, тестові випадки наведенні в папці "[Тестові випадки](/tree/main/%D0%A2%D0%B5%D1%81%D1%82%D0%BE%D0%B2%D1%96%20%D0%B2%D0%B8%D0%BF%D0%B0%D0%B4%D0%BA%D0%B8)"

Проаналізувавши тестові випадки ми можемо прийти до висновків:
1. Послідовний доступ до елементів списків не відрізняеться за часом в обоїх списках.
2. Рандомний доступ до елементів відрізняется за часом, бо пошук елементів в [***LinkedList&lt;T&gt;***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-7.0) відбувается послідовно проходячи весь список до елементу к якому нам потрібен доступ.
3. Вставка елементу в початок списку відрізняется, бо для додавання у [***ArrayList***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-7.0) потрібно зрушувати всі елементи на индекс більше.
4. Вставка елементу в середину списку відрізняется за часом, бо для вставки в середину списку для [***ArrayList***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-7.0) потрібно зрушувати потовину елементі, хоча для [***LinkedList&lt;T&gt;***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-7.0) потрібно пройтись по списку до половини його елементів, що займає достатньо багато часу, але це займає меньше часу чим у [***ArrayList***](https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-7.0).
5. Вставка елементу в кінець списку не відрізняеться за часом о обоїх списках.