int [] Createarray(int Length, int min, int max){
    int [] array = new int [Length];

for (int i = 0; i < array.Length; i++){
    array[i]=new Random().Next(min,max+1);
}
return array;
}

//int Couple(int[] array){
    
//}