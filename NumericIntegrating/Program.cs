using System;

namespace NumericIntegrating
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

		}
		public static double rectanglesMethod(double a, double b, int m, int k){
			double sum = 0;
			double var = a; 
			double step = (b - a) / m;
			double[] mas = new double[3];
			mas [0] = 0;
			mas [1] = step;
			mas [2] = step / 2;
			for (int i = 0; i < m; i++) {
				sum += Y (var + mas[k]);
				var += step;
			}
			return step * sum;
		}
		public static double trapeziumsMethod(double a, double b, int m){
			double sum = 0;
			double step = (b - a) / 2;
			double var = a;
			for(int i=0; i<m-1; i++){
				var += step;
				sum += Y (var);
			}
			return step * ((Y (a) + Y (b)) / 2 + sum);
		}
		public static double Y(double x){
			return Math.Pow (x, 2) * Math.Sqrt ((1-x)/(1+x));
		}
	}
}
