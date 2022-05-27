using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaAlumnosGrid : ContentPage
    {
        public ListaAlumnosGrid()
        {
            InitializeComponent();
            btnRecordatorio.Clicked += MostrarRecordatorio;
        }

        private void MostrarRecordatorio(object sender, EventArgs e)
        {
            DisplayAlert("Recordatorio", "Hacer la tarea", "OK"); ;
        }

        private void SetDarkMode(object sender, EventArgs args)
        {

            if (btnDarkMode.Text == "DarkMode")
            {
                btnDarkMode.Text = "WhiteMode";
                SetColorDarkMode(Color.Azure, 
                    Color.FromHex("#2f2f2f"), 
                    Color.White, 
                    Color.FromHex("#1f1f1f"));
            }
            else
            {
                btnDarkMode.Text = "DarkMode";
                SetColorDarkMode(Color.Black, 
                    Color.FromHex("#efefef"), 
                    Color.FromHex("#1f1f1f"),
                    Color.White);
            }

        }

        private void SetColorDarkMode(Color colorTextoBotonYTitulo,
            Color colorFondoBotonYStackLayout, 
            Color colorTextoLabelStackBody,
            Color colorFondoFrame)
        {
            btnDarkMode.TextColor = colorTextoBotonYTitulo;
            btnDarkMode.BackgroundColor = colorFondoBotonYStackLayout;

            lblMarcos.TextColor = colorTextoLabelStackBody;
            lblTomas.TextColor = colorTextoLabelStackBody;
            lblLautaro.TextColor = colorTextoLabelStackBody;
            lblChino.TextColor = colorTextoLabelStackBody;
            lblGaspar.TextColor = colorTextoLabelStackBody;
            lblAlan.TextColor = colorTextoLabelStackBody;
            lblCesar.TextColor = colorTextoLabelStackBody;
            lblJoana.TextColor = colorTextoLabelStackBody;
            lblGabriel.TextColor = colorTextoLabelStackBody;

            stkBody.BackgroundColor = colorFondoBotonYStackLayout;

            //frmFondo.BackgroundColor = colorFondoFrame;

            lblTitulo.TextColor = colorTextoBotonYTitulo;
        }
    }
}