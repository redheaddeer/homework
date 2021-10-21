﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomework
{
    class Task253
    {

	float** vvod(int n)
	{
		int i, j;
		float** a = new float*[n];
		for (i = 0; i < n; i++)
			a[i] = new float[n];
		cout << "Введите матрицу " << n << "x" << n << ":\n";
		for (i = 0; i < n; i++)
			for (j = 0; j < n; j++)
				cin >> a[i][j];
		return a;
	}

	void vivod(float** a, int n, char* s)
	{
		int i, j;
		cout << s << endl;
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				cout.precision(2);
				cout << fixed << a[i][j] << "\t";
			}
			cout << "\n";
		}
	}

	bool оtr(float** a, int n)
	{
		for (int i = 0; i < n; i++)
			if (a[i][i] > 0)
				return false;
		return true;
	}

	int max(float** a, int n)
	{
		float mx = a[0][0];
		for (int i = 0; i < n; i++)
			if (fabs(mx) < fabs(a[i][i]))
				mx = a[i][i];
		return mx;
	}

	void del(float** a, int n)
	{
		float mx = max(a, n);
		for (int i = 0; i < n; i++)
			for (int j = 0; j < n; j++)
				a[i][j] = a[i][j] / mx; ;
	}

	public int Main()
	{
		try
		{
			const int n = 5;
			float** a;

			a = vvod(n);
			vivod(a, n, "Исходная матрица:");
			if (оtr(a, n))
			{
				del(a, n);
					Console.WriteLine(" Максимальное по модулю = ", max(a, n));
				vivod(a, n, "Матрица после деления на максимальное значение по модулю:");
			}
			else
					Console.WriteLine("Не все значения главной диагонали отрицательны \n");

			return 0;
		}
		catch (System.IO.IOException e)
		{
			Console.WriteLine("\n Введены неверные параметры, операция прервана");
			if (e.Source != null)
				Console.WriteLine("IOException source: {0}", e.Source);
			throw;
		}
	}

	}
}
