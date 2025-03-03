﻿using System;

public class MeuArray<T>
{
	private static int capacidade = 10;
	private int contador = 0;
	private T[] array = new T[capacidade];

	public void AdicionarElementoArray(T elemento)
	{
		if (contador + 1 < 11)
		{
			array[contador] = elemento;
		}
		contador += 1;
	}

	public T this[int index]
	{
		get { return array[index]; }
		set { array[index] = value; }
	}
	
}
