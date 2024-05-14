using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Suma : INotifyPropertyChanged
    {

        private string num1;
        private string num2;
        private string resultado;

        public string Num1
        {
            get
            {
                return num1;
            }
            set
            {
                int numero;
                bool result = int.TryParse(value, out numero);
                if (result)
                {
                    num1 = value;
                    OnPropertyChanged("Num1");
                    OnPropertyChanged("Resultado");

                }
            }
        }

        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                int numero;
                bool result = int.TryParse(value, out numero);
                if (result)
                {
                    num2 = value;
                    OnPropertyChanged("Num2");
                    OnPropertyChanged("Resultado");

                }
            }
        }

        public string Resultado
        {
            get
            {
                int result = int.Parse(num1)+ int.Parse(Num2);
                return result.ToString();
            }
            set
            {
                int result = int.Parse(num1) + int.Parse(Num2);
                resultado = result.ToString();
                OnPropertyChanged("Resultado");

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected int Multiplicar(int num1)
        {
            return num1;
        }
    }
}
