namespace MauiAppMinhasCompras.Views;
public partial class RelatorioProduto : ContentPage
{
	public RelatorioProduto()
	{
		InitializeComponent();

		dtpInicio.Date = DateTime.Today.AddDays(-30); // padrão: ultimos 30 dias
        dtpFim.Date = DateTime.Today;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var inicio = dtpInicio.Date;
        var fim = dtpFim.Date;

        var produtosFiltrados = await App.Db.GetByDateRange(inicio, fim);
        cvProduto.ItemsSource = produtosFiltrados;


    }
}