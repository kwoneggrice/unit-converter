using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Models;

namespace UnitConverter.ViewModels
{
	internal class MainWindowViewModel : ObservableObject
	{
		// 필드
		private Number number = null;
		private double _inputNumber;
		private double _mm;
		private double _cm;
		private double _m;
		private double _km;
		private double _inch;
		private double _feet;
		private double _yard;
		private double _mile;
		private double _ja;
		private double _gan;
		private double _jung;
		private double _li;
		private double _hari;
		
		// 생성자
		public MainWindowViewModel()
		{
			number = new Number();
			_inputNumber = number.InputNumber;
		}

		// 프로퍼티
		public double InputNumber
		{
			get
			{
				Mm = _inputNumber * 10;
				Cm = _inputNumber;
				M = _inputNumber / 100;
				Km = _inputNumber / 1000;
				Inch = _inputNumber / 2.54;
				Feet = _inputNumber / 30.48;
				Yard = _inputNumber / 91.44;
				Mile = _inputNumber / 160934;
				Ja = _inputNumber / 30.30303;
				Gan = _inputNumber / 181.818182;
				Jung = _inputNumber / 10909.0909;
				Li = _inputNumber / 39272.7273;
				Hari = _inputNumber / 185200;
				return _inputNumber;
			}

			set
			{
				SetProperty(ref _inputNumber, value);
			}
		}

		public double Mm
		{
			get
			{
				return _mm;
			}
			set
			{
				SetProperty(ref _mm, value);
			}
		}


		public double Cm
		{
			get
			{
				return _cm;
			}
			set
			{
				SetProperty(ref _cm, value);
			}
		}

		public double M
		{
			get
			{
				return _m;
			}
			set
			{
				SetProperty(ref _m, value);
			}
		}

		public double Km
		{
			get
			{
				return _km;
			}
			set
			{
				SetProperty(ref _km, value);
			}
		}

		public double Inch
		{
			get
			{
				return _inch;
			}
			set
			{
				SetProperty(ref _inch, value);
			}
		}

		public double Feet
		{
			get
			{
				return _feet;
			}

			set
			{
				SetProperty(ref _feet, value);
			}
		}

		public double Yard
		{
			get
			{
				return _yard;
			}

			set
			{
				SetProperty(ref _yard, value);
			}
		}

		public double Mile
		{
			get
			{
				return _mile;
			}

			set
			{
				SetProperty(ref _mile, value);
			}
		}

		public double Ja
		{
			get
			{
				return _ja;
			}

			set
			{
				SetProperty(ref _ja, value);
			}
		}

		public double Gan
		{
			get
			{
				return _gan;
			}

			set
			{
				SetProperty(ref _gan, value);
			}
		}

		public double Jung
		{
			get
			{
				return _jung;
			}

			set
			{
				SetProperty(ref _jung, value);
			}
		}

		public double Li
		{
			get
			{
				return _li;
			}

			set
			{
				SetProperty(ref _li, value);
			}
		}

		public double Hari
		{
			get
			{
				return _hari;
			}

			set
			{
				SetProperty(ref _hari, value);
			}
		}
	}
}
