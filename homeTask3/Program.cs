// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void ShowReverseArray (int [] array, int i = 0) {
    if (i < array.Length){
        Console.Write(array[array.Length - i - 1] + " ");
        ShowReverseArray(array, i + 1);
    }

}

int [] arr = {1, 2, 3, 4, 7, 8, 9};
ShowReverseArray(arr);
