using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDay2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckIfShouldBeEnabled()
        {
            btnGuardar.IsEnabled = false;
            if (!string.IsNullOrWhiteSpace(EntryTitulo.Text) && !string.IsNullOrWhiteSpace(contentEditor.Text))
                btnGuardar.IsEnabled = true;
        }

        private void EntryTitulo_textChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfShouldBeEnabled();
        }

        private void contentEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfShouldBeEnabled();
        }

        private void btnGuardar_Cliecked(object sender, EventArgs e)
        {
            EntryTitulo.Text = string.Empty;
            contentEditor.Text = string.Empty;
        }


    }
}
