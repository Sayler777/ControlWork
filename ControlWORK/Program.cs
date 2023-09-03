// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] arr1 = new string [4] {"Hello","2","world",":-)"};
string [] arr2 = new string [5] {"1234","1567","-2","computer","science"};
string [] arr3 = new string [3] {"Russia","Denmark","Kazan"};

int CountArr(string [] arr){
    int count = 0;
    
    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
        count++;
        }
    }
    return count;
}

void NewArr(string [] arr, int count){

    string [] newArray = new string [count];
    int j = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
        newArray[j] = arr[i];
        Console.Write($"{newArray[j]} ");
        }
    }
    
}