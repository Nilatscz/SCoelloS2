namespace SCoelloS2.Vista;

public partial class Password : ContentPage
{
	public Password()
	{
		InitializeComponent();
       
        
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string[] usuarios = new string[] { "Carlos", "Jose", "Stalin", "Ana" };
        string[] Contraseña = new string[] { "Carlos123", "Jose123", "Nilats", "Ana123" };

        int i = 0;
        for (i = 0; i <= 3; i++)
        {
            if ((TxtUsuario.Text == usuarios[i]) && (TxtContraseña.Text == Contraseña[i]))
            {
                String Login = TxtUsuario.Text;
                Navigation.PushAsync(new Calculoprome(Login));
                i = 4; break;
            }
            else
            {
                if (i == 3)
                {
                    DisplayAlert("Alerta", "Usuario o Contraseña Incorrecta", "Continuar");
                }
            }
            
        }
     
    }
}