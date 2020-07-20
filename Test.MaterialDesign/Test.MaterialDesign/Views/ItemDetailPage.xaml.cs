using System.ComponentModel;
using Test.MaterialDesign.Models;
using Test.MaterialDesign.ViewModels;
using Xamarin.Forms;

namespace Test.MaterialDesign.Views
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class ItemDetailPage : ContentPage
  {
    private ItemDetailViewModel viewModel;

    public ItemDetailPage(ItemDetailViewModel viewModel)
    {
      InitializeComponent();

      BindingContext = this.viewModel = viewModel;
    }

    public ItemDetailPage()
    {
      InitializeComponent();

      var item = new Item
      {
        Text = "Item 1",
        Description = "This is an item description."
      };

      viewModel = new ItemDetailViewModel(item);
      BindingContext = viewModel;
    }
  }
}