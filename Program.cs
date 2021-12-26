// TODO Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// TODO Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// TODO При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] array, int min, int max)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(min, max + 1);
	}
}

string ArrayToString(int[] array)
{
	string text = "[" + array[0].ToString();
	for (int i = 1; i < array.Length; i++)
	{
		text += ", " + array[i].ToString();
	}
	return text += "]";
}

int[] SelectionOfEvenNumbers(int[] startArray)
{
	int[] newArray = new int[startArray.Length];
	int index = 0;
	for (int i = 0; i < startArray.Length; i++)
	{
		if (startArray[i] % 2 == 0)
		{
			newArray[index] = startArray[i];
			index++;
		}
	}
	Array.Resize(ref newArray, index);
	return newArray;
}

void Demo()
{
	Console.Clear();

	int lengthArray = new Random().Next(10, 50);

	int[] namberArray = new int[lengthArray];
	FillArray(namberArray, 1, 20);
	Console.WriteLine(ArrayToString(namberArray));

	int[] arrayOfEvenNamber = SelectionOfEvenNumbers(namberArray);
	Console.WriteLine();
	Console.WriteLine(ArrayToString(arrayOfEvenNamber));
}

Demo();