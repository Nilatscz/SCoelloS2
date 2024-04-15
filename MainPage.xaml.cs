using Windows.Data.Xml.Dom;

namespace SCoelloS2
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (pkEstudiantes.SelectedIndex == -1)
            {
                DisplayAlert("Falta", " Seleccionar nombre del Estudiante", " Cerrar");
            }
            else
            { 
                string fecha= dpFecha.Date.ToString("MM/dd/yyyy");
                string Estudy = pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();
                
                double P1 = double.Parse(TxtSegui1.Text);
                double Ex1 = double.Parse(TxtExamen1.Text);
                double P2 = double.Parse(TxtSegui2.Text);
                double Ex2 = double.Parse(TxtExamen2.Text);
                double Nf = 0;
                if (((P1 >= 0 && Ex1 >= 0) && (P1 <= 10 && Ex1 <= 10)) &&
                    ((P2 >= 0 && Ex2 >= 0) && (P2 <= 10 && Ex2 <= 10)))
                {
                    P1 = (P1 * 0.3) + (Ex1 * 0.2);
                    P2 = (P2 * 0.3) + (Ex2 * 0.2);
                    Nf = P2 + P1;
                    DisplayAlert("Estamos", " Calculando tu nota, " + Estudy, " Continuar");
                    if (Nf >= 7)
                    {
                        DisplayAlert("Promedio final: ", "Estudiante , " + Estudy +
                       "\nFecha: " + fecha +
                       "\nNota parcial 1: " + P1 +
                       "\nNota parcial 2: " + P2 +
                       "\nNota Final: " + Nf,
                                          " Aprobado");
                    }
                    else
                    {
                        if (Nf >= 5 && Nf <= 6.9)
                        {
                            DisplayAlert("Promedio final: ", "Estudiante , " + Estudy +
                                "\nFecha: " + fecha +
                           "\nNota parcial 1: " + P1 +
                           "\nNota parcial 2: " + P2 +
                           "\nNota Final: " + Nf,
                                              " Complementario");
                        }
                        else
                        {
                            if (Nf < 5)
                            {
                                DisplayAlert("Promedio final: ", "Estudiante , " + Estudy +
                                    "\nFecha: " + fecha +
                               "\nNota parcial 1: " + P1 +
                               "\nNota parcial 2: " + P2 +
                               "\nNota Final: " + Nf,
                                                  " Reprobado");
                            }

                        }
                    }
                }else
                {
                    DisplayAlert("Atención", " Revisar las notas ingresadas, " + Estudy, " Continuar");
                }
               
            }


        }
    }

}
