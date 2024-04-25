using System;
using System.Collections.Generic;
using System.ComponentModel; // Añadí este using para INotifyPropertyChanged
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11
{
    public class Suma : INotifyPropertyChanged // Implementé INotifyPropertyChanged
    {
        private string num1;
        private string num2;
        private string resultado; // Cambié el nombre de la variable a minúsculas para seguir convención
        private string resultadoStr; 

        public string Num1
        {
            get { return num1; }
            set
            {
                if (decimal.TryParse(value, out decimal numero))
                {
                    num1 = value;
                    OnPropertyChanged(nameof(Num1)); // Cambié "num1" por nameof(Num1) para evitar errores tipográficos
                    Resultado(); // Llamé al método para calcular el resultado
                }
            }
        }

        public string Num2
        {
            get { return num2; }
            set
            {
                if (decimal.TryParse(value, out decimal numero))
                {
                    num2 = value;
                    OnPropertyChanged(nameof(Num2)); 
                    Resultado(); // Llamé al método para calcular el resultado
                }
            }
        }

        public string ResultadoStr
        {
            get { return resultadoStr; }
            set
            {
                resultadoStr = value;
                OnPropertyChanged(nameof(ResultadoStr)); // Cambié "ResultadoStr" por nameof(ResultadoStr) para evitar errores tipográficos
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Resultado()
        {
            if (decimal.TryParse(Num1, out decimal num1Decimal) && decimal.TryParse(Num2, out decimal num2Decimal))
            {
                decimal res = num1Decimal + num2Decimal;
                ResultadoStr = res.ToString(); 
            }
        }
    }
}
