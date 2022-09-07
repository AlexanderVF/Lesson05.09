Console.Clear();
int[] GetArray(int size, int minValue, MaxValue) {
    int[] res = new int[size];

    for (int = 0; int < size; int++) {
        res[i] = new Random().Next(minValue, maxValue +1);
    }

    return res;
}

int[] arr = GetArray(7, 0, 10);
Console.WriteLine(string.Join(",", arr));

for (int i = 0; i < Array.MaxLength/2; i++) {
    int temp = arr[i];
    arr[i] = arr[arr.length - i -1];
    arr[arr.length - i -1] = temp;

}

Console.WriteLine(string.Join(",", arr));