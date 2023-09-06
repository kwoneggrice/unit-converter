using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Models
{
	internal class Number : ObservableObject
	{
		private double _inputNumber;
		public double InputNumber
		{
			get
			{
				return _inputNumber;
			}
			set
			{
				SetProperty(ref _inputNumber, value);
			}
		}
	}
}
